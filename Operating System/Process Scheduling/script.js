
function menu_show(){
  let height_input_algorithm =  $(".input_algorithm").css("height");

  $(".Data, .PID").css("visibility", "hidden");
  $(".work__1, .work__2, .work__3, .work__4, .work__5").css("visibility", "hidden");
  $(".Priority, .Priority1, .Priority2, .Priority3, .Priority4, .Priority5").css("visibility", "hidden");
  $(".Priority, .Priority1, .Priority2, .Priority3, .Priority4, .Priority5").css("width", "0px");
  $(".work__place").css("visibility", "visible");
  $(".work__place").animate({
    margin: "1px",
    width: "32%",
    height: "0px"
  }, 700);

  if( height_input_algorithm === "37px"){
    $(".input_algorithm").animate({
      height: "200px"
    }, 700);
    $(".select_form").css("visibility", "visible");
    $(".btn__start").css("visibility", "visible");
  }
  else {
    $(".input_algorithm").animate({
      height: "37px"
    }, 700);
    $(".input_algorithm").animate({
      height: "200px"
    }, 700);
    $(".MaxProcess").val("");
    $(".MaxTime").val("");
    $(".Count_process").val(0);
    $(".Count_time").val(0);


  }
  $(".select_form").css("visibility", "visible");
  $(".btn__start").css("visibility", "visible");
}



function process(){
  /* Check null*/
  if($(".Count_process").val() === null || $(".Count_time").val() === null){
    return alert("Для продолжения, необходимо заполнить все поля.");
  }
  $(".Process").html("0");
  $(".work__1, .work__2, .work__3, .work__4, .work__5").css("background", "white");
  $(".work").addClass("active");



/* Preparation */

   $(".Count_process").css("visibility", "hidden");
   $(".Count_time").css("visibility", "hidden");
   $(".btn__start").css("visibility", "hidden");

    $(".input_algorithm").animate({
      width: "70%",
      height: "37px"
    }, 800);

    let count = $(".Count_process").val(), time = $(".Count_time").val();


    if(count === "1"){
      $(".work__place").animate({
        margin: "1px",
        width: "70%",
        height: "68px"
      }, 800);
      $(".work__1").css("visibility", "visible");

      $(".LT1").html(getRandomInt(1, time));
    }
    else if(count === "2"){
      $(".work__place").animate({
        margin: "1px",
        width: "70%",
        height: "108px"
      }, 800);
      $(".work__1, .work__2").css("visibility", "visible");
      $(".LT1").html(getRandomInt(1, time));
      $(".LT2").html(getRandomInt(1, time));
    }
    else if(count === "3"){
      $(".work__place").animate({
        margin: "1px",
        width: "70%",
        height: "148px"
      }, 800);
      $(".work__1, .work__2, .work__3").css("visibility", "visible");
      $(".LT1").html(getRandomInt(1, time));
      $(".LT2").html(getRandomInt(1, time));
      $(".LT3").html(getRandomInt(1, time));
    }
    else if(count === "4"){
      $(".work__place").animate({
        margin: "1px",
        width: "70%",
        height: "188px"
      }, 800);
      $(".work__1, .work__2, .work__3, .work__4").css("visibility", "visible");
      $(".LT1").html(getRandomInt(1, time));
      $(".LT2").html(getRandomInt(1, time));
      $(".LT3").html(getRandomInt(1, time));
      $(".LT4").html(getRandomInt(1, time));
    }
    else if(count === "5"){
      $(".work__place").animate({
        margin: "1px",
        width: "70%",
        height: "228px"
      }, 800);
      $(".work__1, .work__2, .work__3, .work__4, .work__5").css("visibility", "visible");
      $(".LT1").html(getRandomInt(1, time));
      $(".LT2").html(getRandomInt(1, time));
      $(".LT3").html(getRandomInt(1, time));
      $(".LT4").html(getRandomInt(1, time));
      $(".LT5").html(getRandomInt(1, time));

    }
    Count_Lead_Time = (Number)($(".LT1").html()) + (Number)($(".LT2").html()) + (Number)($(".LT3").html()) + (Number)($(".LT4").html()) + (Number)($(".LT5").html());
    $(".Data, .PID").css("visibility", "visible");


/* RR*/

/* Bilet*/
    if($(".algorithm").val() == "Bilet")
    {
      process__Bilet(Number(count));
    }
    else {
      process__RR(Number(count));
    }



    $(".Count_process").val(0);
    $(".Count_time").val(0);
}

function process__RR(Count)
{

  Loop_RR(Count);

}

function Loop_RR(Count){
  for(let i = 1; i<=Count; i++){
    setTimeout(function(){


      if(i === 1 && $(".work__1").hasClass("active")){
          TT_func();
          if($(".work__2").hasClass("active")){
              $(".LOST2").html(((Number)($(".LOST2").html()))+1);
          }
          if($(".work__3").hasClass("active")){
              $(".LOST3").html(((Number)($(".LOST3").html()))+1);
          }
          if($(".work__4").hasClass("active")){
              $(".LOST4").html(((Number)($(".LOST4").html()))+1);
          }
          if($(".work__5").hasClass("active")){
              $(".LOST5").html(((Number)($(".LOST5").html()))+1);
          }

          ReactF();
          FN_func();

          $(".work__1").css("background-color", "rgb(18, 212, 66)" );
          $(".work__2, .work__3, .work__4, .work__5").css("background-color", "white" );
          $(".LT1").html(((Number)($(".LT1").html()))-1);
          if($(".LT1").html() === "0")
            $(".work__1").removeClass("active");
      }
      else if(i === 2 && $(".work__2").hasClass("active")){
        TT_func();
        if($(".work__1").hasClass("active")){
            $(".LOST1").html(((Number)($(".LOST1").html()))+1);
        }
        if($(".work__3").hasClass("active")){
            $(".LOST3").html(((Number)($(".LOST3").html()))+1);
        }
        if($(".work__4").hasClass("active")){
            $(".LOST4").html(((Number)($(".LOST4").html()))+1);
        }
        if($(".work__5").hasClass("active")){
            $(".LOST5").html(((Number)($(".LOST5").html()))+1);
        }

        ReactF();
        FN_func();

        $(".work__2").css("background-color", "rgb(18, 212, 66)" );
        $(".work__1, .work__3, .work__4, .work__5").css("background-color", "white" );
        $(".LT2").html(((Number)($(".LT2").html()))-1);

        if($(".LT2").html() === "0")
          $(".work__2").removeClass("active");
      }
      else if(i === 3 && $(".work__3").hasClass("active")){
        TT_func();
        if($(".work__1").hasClass("active")){
            $(".LOST1").html(((Number)($(".LOST1").html()))+1);
        }
        if($(".work__2").hasClass("active")){
            $(".LOST2").html(((Number)($(".LOST2").html()))+1);
        }
        if($(".work__4").hasClass("active")){
            $(".LOST4").html(((Number)($(".LOST4").html()))+1);
        }
        if($(".work__5").hasClass("active")){
            $(".LOST5").html(((Number)($(".LOST5").html()))+1);
        }

        ReactF();
        FN_func();

        $(".work__3").css("background-color", "rgb(18, 212, 66)" );
        $(".work__1, .work__2, .work__4, .work__5").css("background-color", "white" );
        $(".LT3").html(((Number)($(".LT3").html()))-1);

        if($(".LT3").html() === "0")
          $(".work__3").removeClass("active");
      }
      else if(i === 4 && $(".work__4").hasClass("active")){
        TT_func();
        if($(".work__1").hasClass("active")){
            $(".LOST1").html(((Number)($(".LOST1").html()))+1);
        }
        if($(".work__2").hasClass("active")){
            $(".LOST2").html(((Number)($(".LOST2").html()))+1);
        }
        if($(".work__3").hasClass("active")){
            $(".LOST3").html(((Number)($(".LOST3").html()))+1);
        }
        if($(".work__5").hasClass("active")){
            $(".LOST5").html(((Number)($(".LOST5").html()))+1);
        }

        ReactF();
        FN_func();

        $(".work__4").css("background-color", "rgb(18, 212, 66)" );
        $(".work__1, .work__2, .work__3, .work__5").css("background-color", "white" );
        $(".LT4").html(((Number)($(".LT4").html()))-1);

        if($(".LT4").html() === "0")
          $(".work__4").removeClass("active");
      }
      else if(i === 5 && $(".work__5").hasClass("active")){
        TT_func();
        if($(".work__1").hasClass("active")){
            $(".LOST1").html(((Number)($(".LOST1").html()))+1);
        }
        if($(".work__2").hasClass("active")){
            $(".LOST2").html(((Number)($(".LOST2").html()))+1);
        }
        if($(".work__3").hasClass("active")){
            $(".LOST3").html(((Number)($(".LOST3").html()))+1);
        }
        if($(".work__4").hasClass("active")){
            $(".LOST4").html(((Number)($(".LOST4").html()))+1);
        }

        ReactF();
        FN_func();

        $(".work__5").css("background-color", "rgb(18, 212, 66)" );
        $(".work__1, .work__2, .work__3, .work__4").css("background-color", "white" );
        $(".LT5").html(((Number)($(".LT5").html()))-1);

        if($(".LT5").html() === "0")
          $(".work__5").removeClass("active");
        }

        if(($(".work__1").hasClass("active") || $(".work__2").hasClass("active") || $(".work__3").hasClass("active") || $(".work__4").hasClass("active")|| $(".work__5").hasClass("active")) && i === Number(Count)) {
          Loop_RR(Count);
        }


      }, 850 * (i + 1));
    }
}

function TT_func(){
  if($(".work__1").hasClass("active")){
    $(".TT1").html(((Number)($(".TT1").html()))+1);
  }
  if($(".work__2").hasClass("active")){
    $(".TT2").html(((Number)($(".TT2").html()))+1);
  }
  if($(".work__3").hasClass("active")){
    $(".TT3").html(((Number)($(".TT3").html()))+1);
  }
  if($(".work__4").hasClass("active")){
    $(".TT4").html(((Number)($(".TT4").html()))+1);
  }
  if($(".work__5").hasClass("active")){
    $(".TT5").html(((Number)($(".TT5").html()))+1);
  }
}

function ReactF(){
  if(isNaN((parseFloat($(".LOST1").html())) / (parseFloat($(".TT1").html()))) === false )
    $(".ReactV1").html(((parseFloat($(".LOST1").html())) / (parseFloat($(".TT1").html()))).toFixed(3));

  if(isNaN((parseFloat($(".LOST2").html())) / (parseFloat($(".TT2").html()))) === false )
    $(".ReactV2").html(((parseFloat($(".LOST2").html())) / (parseFloat($(".TT2").html()))).toFixed(3));

  if(isNaN((parseFloat($(".LOST3").html())) / (parseFloat($(".TT3").html()))) === false )
    $(".ReactV3").html(((parseFloat($(".LOST3").html())) / (parseFloat($(".TT3").html()))).toFixed(3));

  if(isNaN((parseFloat($(".LOST4").html())) / (parseFloat($(".TT4").html()))) === false )
    $(".ReactV4").html(((parseFloat($(".LOST4").html())) / (parseFloat($(".TT4").html()))).toFixed(3));

  if(isNaN((parseFloat($(".LOST5").html())) / (parseFloat($(".TT5").html()))) === false )
    $(".ReactV5").html(((parseFloat($(".LOST5").html())) / (parseFloat($(".TT5").html()))).toFixed(3));
}

function FN_func(){
    if(isFinite((parseFloat($(".TT1").html())) / (parseFloat($(".LOST1").html()))))
      $(".FN1").html(((parseFloat($(".TT1").html())) / (parseFloat($(".LOST1").html()))).toFixed(3));

    if(isFinite((parseFloat($(".TT2").html())) / (parseFloat($(".LOST2").html()))))
      $(".FN2").html(((parseFloat($(".TT2").html())) / (parseFloat($(".LOST2").html()))).toFixed(3));

    if(isFinite((parseFloat($(".TT3").html())) / (parseFloat($(".LOST3").html()))))
      $(".FN3").html(((parseFloat($(".TT3").html())) / (parseFloat($(".LOST3").html()))).toFixed(3));

    if(isFinite((parseFloat($(".TT4").html())) / (parseFloat($(".LOST4").html()))))
      $(".FN4").html(((parseFloat($(".TT4").html())) / (parseFloat($(".LOST4").html()))).toFixed(3));

    if(isFinite((parseFloat($(".TT5").html())) / (parseFloat($(".LOST5").html()))))
      $(".FN5").html(((parseFloat($(".TT5").html())) / (parseFloat($(".LOST5").html()))).toFixed(3));

}

function process__Bilet(Count){
  $(".Priority").css("visibility", "visible");
  $(".Priority_head").html("Priority");
  $(".Priority, .Priority1, .Priority2, .Priority3, .Priority4, .Priority5").css("width", "140px");

  if(Count === 1){
    $(".Priority1").css("visibility", "visible");
  }
  else if(Count === 2){
    $(".Priority1, .Priority2").css("visibility", "visible");
  }
  else if(Count === 3){
    $(".Priority1, .Priority2, .Priority3").css("visibility", "visible");
  }
  else if(Count === 4){
    $(".Priority1, .Priority2, .Priority3, .Priority4").css("visibility", "visible");
  }
  else if(Count === 5){
    $(".Priority1, .Priority2, .Priority3, .Priority4, .Priority5").css("visibility", "visible");
  }

    $(".Priority1").html(getRandomInt(1, 4));
    $(".Priority2").html(getRandomInt(1, 4));
    $(".Priority3").html(getRandomInt(1, 4));
    $(".Priority4").html(getRandomInt(1, 4));
    $(".Priority5").html(getRandomInt(1, 4));
    Bilet__loop(Count);
}

function Bilet__loop(Count) {
  for(let i = 1; i<=Count; i++){
    setTimeout(function(){
      if($(".work__1").hasClass("active"))
        $(".Priority1").html(Number($(".Priority1").html())+getRandomInt(1, 4));

      if($(".work__2").hasClass("active"))
        $(".Priority2").html(Number($(".Priority2").html())+getRandomInt(1, 4));

      if($(".work__3").hasClass("active"))
        $(".Priority3").html(Number($(".Priority3").html())+getRandomInt(1, 4));

      if($(".work__4").hasClass("active"))
        $(".Priority4").html(Number($(".Priority4").html())+getRandomInt(1, 4));

      if($(".work__5").hasClass("active"))
        $(".Priority5").html(Number($(".Priority5").html())+getRandomInt(1, 4));

      if(MaxPriority(Count) === 1 && $(".work__1").hasClass("active")){
          TT_func();
          if($(".work__2").hasClass("active")){
              $(".LOST2").html(((Number)($(".LOST2").html()))+1);
          }
          if($(".work__3").hasClass("active")){
              $(".LOST3").html(((Number)($(".LOST3").html()))+1);
          }
          if($(".work__4").hasClass("active")){
              $(".LOST4").html(((Number)($(".LOST4").html()))+1);
          }
          if($(".work__5").hasClass("active")){
              $(".LOST5").html(((Number)($(".LOST5").html()))+1);
          }

          ReactF();
          FN_func();

          $(".work__1").css("background-color", "rgb(18, 212, 66)" );
          $(".work__2, .work__3, .work__4, .work__5").css("background-color", "white" );
          $(".LT1").html(((Number)($(".LT1").html()))-1);
          if($(".LT1").html() === "0")
            $(".work__1").removeClass("active");

          }
      else if(MaxPriority(Count) === 2 && $(".work__2").hasClass("active")){

        TT_func();
        if($(".work__1").hasClass("active")){
            $(".LOST1").html(((Number)($(".LOST1").html()))+1);
        }
        if($(".work__3").hasClass("active")){
            $(".LOST3").html(((Number)($(".LOST3").html()))+1);
        }
        if($(".work__4").hasClass("active")){
            $(".LOST4").html(((Number)($(".LOST4").html()))+1);
        }
        if($(".work__5").hasClass("active")){
            $(".LOST5").html(((Number)($(".LOST5").html()))+1);
        }

        ReactF();
        FN_func();

        $(".work__2").css("background-color", "rgb(18, 212, 66)" );
        $(".work__1, .work__3, .work__4, .work__5").css("background-color", "white" );
        $(".LT2").html(((Number)($(".LT2").html()))-1);
        if($(".LT2").html() === "0")
          $(".work__2").removeClass("active");
        }
        else if(MaxPriority(Count) === 3 && $(".work__3").hasClass("active")){

          TT_func();
          if($(".work__1").hasClass("active")){
              $(".LOST1").html(((Number)($(".LOST1").html()))+1);
          }
          if($(".work__2").hasClass("active")){
              $(".LOST2").html(((Number)($(".LOST2").html()))+1);
          }
          if($(".work__4").hasClass("active")){
              $(".LOST4").html(((Number)($(".LOST4").html()))+1);
          }
          if($(".work__5").hasClass("active")){
              $(".LOST5").html(((Number)($(".LOST5").html()))+1);
          }

          ReactF();
          FN_func();

          $(".work__3").css("background-color", "rgb(18, 212, 66)" );
          $(".work__1, .work__2, .work__4, .work__5").css("background-color", "white" );
          $(".LT3").html(((Number)($(".LT3").html()))-1);
          if($(".LT3").html() === "0")
            $(".work__3").removeClass("active");
        }
        else if(MaxPriority(Count) === 4 && $(".work__4").hasClass("active")){

          TT_func();
          if($(".work__1").hasClass("active")){
              $(".LOST1").html(((Number)($(".LOST1").html()))+1);
          }
          if($(".work__2").hasClass("active")){
              $(".LOST2").html(((Number)($(".LOST2").html()))+1);
          }
          if($(".work__3").hasClass("active")){
              $(".LOST3").html(((Number)($(".LOST3").html()))+1);
          }
          if($(".work__5").hasClass("active")){
              $(".LOST5").html(((Number)($(".LOST5").html()))+1);
          }

          ReactF();
          FN_func();

          $(".work__4").css("background-color", "rgb(18, 212, 66)" );
          $(".work__1, .work__2, .work__3, .work__5").css("background-color", "white" );
          $(".LT4").html(((Number)($(".LT4").html()))-1);
          if($(".LT4").html() === "0")
            $(".work__4").removeClass("active");
        }
        else if(MaxPriority(Count) === 5 && $(".work__5").hasClass("active")){

          TT_func();
          if($(".work__1").hasClass("active")){
              $(".LOST1").html(((Number)($(".LOST1").html()))+1);
          }
          if($(".work__2").hasClass("active")){
              $(".LOST2").html(((Number)($(".LOST2").html()))+1);
          }
          if($(".work__3").hasClass("active")){
              $(".LOST3").html(((Number)($(".LOST3").html()))+1);
          }
          if($(".work__4").hasClass("active")){
              $(".LOST4").html(((Number)($(".LOST4").html()))+1);
          }

          ReactF();
          FN_func();

          $(".work__5").css("background-color", "rgb(18, 212, 66)" );
          $(".work__1, .work__2, .work__3, .work__4").css("background-color", "white" );
          $(".LT5").html(((Number)($(".LT5").html()))-1);

          if($(".LT5").html() === "0")
            $(".work__5").removeClass("active");

        }

      if(($(".work__1").hasClass("active") || $(".work__2").hasClass("active") || $(".work__3").hasClass("active") || $(".work__4").hasClass("active")|| $(".work__5").hasClass("active")) && i === Number(Count)) {
        Bilet__loop(Count);
      }

    }, 800 * (i + 1));
    }
}

function MaxPriority(Count){
  let Prio_1, Prio_2, Prio_3, Prio_4, Prio_5;
  Prio_1 = Number( $(".Priority1").html());
  Prio_2 = Number( $(".Priority2").html());
  Prio_3 = Number( $(".Priority3").html());
  Prio_4 = Number( $(".Priority4").html());
  Prio_5 = Number( $(".Priority5").html());

  if(Count==1){
    return 1;
  }
  else if(Count===2){
    if( Prio_1>=Prio_2)
      return 1;
    else {
      return 2;
    }
  }
  else if(Count===3){
    if( Prio_1>=Prio_2 && Prio_1>= Prio_3){
      return 1;
    }
    else if( Prio_2>=Prio_1 && Prio_2>= Prio_3){
      return 2;
    }
    else if( Prio_3>=Prio_1 && Prio_3>= Prio_2){
      return 3;
    }
  }
  else if(Count===4){
    if( Prio_1>=Prio_2 && Prio_1>= Prio_3 && Prio_1 >= Prio_4 ){
      return 1;
    }
    else if( Prio_2>=Prio_1 && Prio_2>= Prio_3 && Prio_2 >= Prio_4 ){
      return 2;
    }
    else if( Prio_3>=Prio_1 && Prio_3>= Prio_2 && Prio_3 >= Prio_4 ){
      return 3;
    }
    else if( Prio_4>=Prio_1 && Prio_4>= Prio_2 && Prio_4 >= Prio_3 ){
      return 4;
    }
  }
  else {
    if( Prio_1>=Prio_2 && Prio_1>= Prio_3 && Prio_1 >= Prio_4 && Prio_1>=Prio_5){
      return 1;
    }
    else if( Prio_2>=Prio_1 && Prio_2>= Prio_3 && Prio_2 >= Prio_4 && Prio_2>=Prio_5){
      return 2;
    }
    else if( Prio_3>=Prio_1 && Prio_3>= Prio_2 && Prio_3 >= Prio_4 && Prio_3>=Prio_5){
      return 3;
    }
    else if( Prio_4>=Prio_1 && Prio_4>= Prio_2 && Prio_4 >= Prio_3 && Prio_4>=Prio_5){
      return 4;
    }
    else if( Prio_5>=Prio_1 && Prio_5>= Prio_2 && Prio_5 >= Prio_3 && Prio_5>=Prio_4){
      return 5;
    }
  }
}

function getRandomInt(min, max) {
  return Math.floor(Math.random() * (max - min)) + min;
}
