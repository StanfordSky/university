
var red = 0,
    green = 0,
    blue = 0;

var lineWeigth = 5;

window.onload = function(){

    var canvas = document.getElementById("canvas"), 
    context = canvas.getContext("2d"),
    w = canvas.width,
    h = canvas.height;
        
    var mouse = { x:0, y:0};
    var draw = false;

    
    
    // Event MouseDown    
    canvas.addEventListener("mousedown", function(e){
        context.lineWidth = lineWeigth;
        context.strokeStyle = "rgb(" + red + "," + green + "," + blue + ")";
        mouse.x = e.pageX - this.offsetLeft;
        mouse.y = e.pageY - this.offsetTop;
        draw = true;
        context.beginPath();
        context.moveTo(mouse.x, mouse.y);
    });

    // Event MouseMove  
    canvas.addEventListener("mousemove", function(e){
    if(draw==true){
        
        mouse.x = e.pageX - this.offsetLeft;
        mouse.y = e.pageY - this.offsetTop;
        context.lineTo(mouse.x, mouse.y);
        context.stroke();
    }
    });

    // Event MouseUp  
    canvas.addEventListener("mouseup", function(e){   
        mouse.x = e.pageX - this.offsetLeft;
        mouse.y = e.pageY - this.offsetTop;
        context.lineTo(mouse.x, mouse.y);
        context.stroke();
        context.closePath();
        draw = false;
    });

    
}

// Set current color
function SetColor(red, green, blue){   
    this.red = red;
    this.green = green;
    this.blue = blue;
    document.getElementById("current__color__block").style.backgroundColor = "rgb(" + red + "," + green + "," + blue + ")";
}

// Set Weigth
function SetWeigth(weigth){
    lineWeigth = weigth;
    document.getElementById("thickness_size_custom").value = weigth;
}

// SetCustomWeigth
function SetCustomWeigth(){
    if(document.getElementById("thickness_size_custom").value <=5)
        lineWeigth = 1;
    else
        lineWeigth = document.getElementById("thickness_size_custom").value;
}

