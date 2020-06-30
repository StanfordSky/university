
// Params for Canvas
var canvas;
var context;

// Color
var red = 0,
    green = 0,
    blue = 0;

// Weigth line figure
var lineWeigth = 5;

// Number figure
var figure = 1;

// Params for input text
var inputText = false,
    font = "Verdana",
    size = "22px";


window.onload = function(){
    // Create canvas
    canvas = document.getElementById("canvas");
    // Define context
    context = canvas.getContext("2d"),
    // Receive size canvas
    w = canvas.width,
    h = canvas.height;
  
    // Helper variables
    var mouse = { x:0, y:0};
    var draw = false;

    // Event MouseDown    
    canvas.addEventListener("mousedown", function(e){
        // Defining selected figure and draw them
        mouse.x = e.pageX - this.offsetLeft;
        mouse.y = e.pageY - this.offsetTop;
        // Checking active flag input text
        if(inputText == true)
        {
            let result = prompt("Введите текст:","");
            context.font = size + " " + font;
            if(result != null)
                context.fillText(result, mouse.x, mouse.y);
            inputText = false;
            return;
        }
        context.lineWidth = lineWeigth;
        context.strokeStyle = "rgb(" + red + "," + green + "," + blue + ")";

        if(figure == 1) // curve
        {
            draw = true;
            context.beginPath();
            context.moveTo(mouse.x, mouse.y);
        }   
    });

    // Event MouseMove  
    canvas.addEventListener("mousemove", function(e){
        // Defining selected figure and draw them
        if(figure == 1) // curve
        {
            if(draw==true)
            {
                mouse.x = e.pageX - this.offsetLeft;
                mouse.y = e.pageY - this.offsetTop;
                context.lineTo(mouse.x, mouse.y);
                context.stroke();      
            }
        }
    });


    // Event MouseUp  
    canvas.addEventListener("mouseup", function(e){ 
        context.save();

        // Defining selected figure and draw them
        if(figure == 1) // curve
        {  
            mouse.x = e.pageX - this.offsetLeft;
            mouse.y = e.pageY - this.offsetTop;
            context.lineTo(mouse.x, mouse.y);
            context.stroke();
            context.closePath();
            draw = false;
        }
        else if(figure == 2)
        {
            context.beginPath();
            context.moveTo(mouse.x, mouse.y);
            context.lineTo(e.pageX - this.offsetLeft, e.pageY - this.offsetTop);
            context.stroke();
            context.closePath();
        } 
        else if(figure == 3) // circle
        {
            context.beginPath();
            context.arc((e.pageX - this.offsetLeft), (e.pageY - this.offsetTop), (e.pageX - this.offsetLeft)-mouse.x, 0, (Math.PI / 180) * 360);
            context.stroke();
            context.closePath();
        } 
        else if(figure == 4) // rectangle
        {
            context.beginPath();
            context.rect(mouse.x, mouse.y, (e.pageX - this.offsetLeft)-mouse.x, (e.pageY - this.offsetTop)-mouse.y);
            context.stroke();
            context.closePath();
            context.fill(mouse.x+2, mouse.y+2);
            context.fill()
        }
        else if(figure == 5) // triangle
        {
            context.beginPath();
            context.moveTo(mouse.x, mouse.y);
            context.lineTo(e.pageX - this.offsetLeft, e.pageY - this.offsetTop);
            context.moveTo(mouse.x, mouse.y);
            context.lineTo(mouse.x, e.pageY - this.offsetTop);
            context.moveTo(mouse.x, e.pageY - this.offsetTop);
            context.lineTo(e.pageX - this.offsetLeft, e.pageY - this.offsetTop);
            context.stroke();
            context.closePath();
        }
        else if(figure == 6) // triangle #2
        {
            context.beginPath();
            context.moveTo(mouse.x +((e.pageX - this.offsetLeft)-mouse.x)/2, mouse.y);
            context.lineTo(e.pageX - this.offsetLeft, e.pageY - this.offsetTop);
            context.moveTo(mouse.x +((e.pageX - this.offsetLeft)-mouse.x)/2, mouse.y);
            context.lineTo(mouse.x, e.pageY - this.offsetTop);
            context.moveTo(mouse.x, e.pageY - this.offsetTop);
            context.lineTo(e.pageX - this.offsetLeft, e.pageY - this.offsetTop);
            context.stroke();
            context.closePath();
        }
        else if(figure == 7) // triangle #2
        {
            context.beginPath();

            context.moveTo(mouse.x +((e.pageX - this.offsetLeft)-mouse.x)/2, mouse.y);
            context.lineTo((e.pageX - this.offsetLeft), (e.pageY - this.offsetTop)-((e.pageY - this.offsetTop)-mouse.y)/2);
            context.moveTo(mouse.x +((e.pageX - this.offsetLeft)-mouse.x)/2, mouse.y);
            context.lineTo(mouse.x, (e.pageY - this.offsetTop)-((e.pageY - this.offsetTop)-mouse.y)/2);
            context.moveTo(mouse.x +((e.pageX - this.offsetLeft)-mouse.x)/2, e.pageY - this.offsetTop);
            context.lineTo((e.pageX - this.offsetLeft), (e.pageY - this.offsetTop)-((e.pageY - this.offsetTop)-mouse.y)/2);
            context.moveTo(mouse.x +((e.pageX - this.offsetLeft)-mouse.x)/2, e.pageY - this.offsetTop);
            context.lineTo(mouse.x, (e.pageY - this.offsetTop)-((e.pageY - this.offsetTop)-mouse.y)/2);
            context.stroke();
            context.closePath();
        }
        else if(figure == 8) // up-arrow
        {
            context.beginPath();

            context.moveTo(mouse.x +((e.pageX - this.offsetLeft)-mouse.x)/2, mouse.y);
            context.lineTo(e.pageX - this.offsetLeft, e.pageY - this.offsetTop);
            context.moveTo(mouse.x +((e.pageX - this.offsetLeft)-mouse.x)/2, mouse.y);
            context.lineTo(mouse.x, e.pageY - this.offsetTop);
            context.stroke();
            context.closePath();
        }
        else if(figure == 9) // next arrow
        {
            context.beginPath();
            context.moveTo(mouse.x, mouse.y);
            context.lineTo((e.pageX - this.offsetLeft), (e.pageY - this.offsetTop)-((e.pageY - this.offsetTop)-mouse.y)/2);
            context.lineTo((e.pageX - this.offsetLeft), (e.pageY - this.offsetTop)-((e.pageY - this.offsetTop)-mouse.y)/2);
            context.lineTo(mouse.x, (e.pageY - this.offsetTop));
            context.stroke();
            context.closePath();
        }
        else if(figure == 10) // triangle #2
        {
            context.beginPath();
            context.moveTo(e.pageX - this.offsetLeft, mouse.y);
            context.lineTo(mouse.x, (e.pageY - this.offsetTop)-((e.pageY - this.offsetTop)-mouse.y)/2);
            context.moveTo(e.pageX - this.offsetLeft, e.pageY - this.offsetTop);
            context.lineTo(mouse.x, (e.pageY - this.offsetTop)-((e.pageY - this.offsetTop)-mouse.y)/2);
            context.stroke();
            context.closePath();
        }
        
        });

        // define event upload image
        document.getElementById("choose__box__upload").addEventListener("change", UploadImage, false);

}

// Set current color
function SetColor(red, green, blue){   
    context.restore();
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

// Set Custom Pen
function SetFigure(number){
    figure = number;
}

// Define eraser
function Eraser()
{
    figure = 1;
    this.red = 255;
    this.green = 255;
    this.blue = 255;
    document.getElementById("current__color__block").style.backgroundColor = "rgb(" + red + "," + green + "," + blue + ")";
}

// Active state
function InputText()
{
    // Toggle
    if(inputText)
        inputText = false;
    else
        inputText = true;
}

// ChangeFontSize
function ChangeFontSize()
{
    let result = prompt("Введите размер шрифта.\n\nПример:\n- 14px\n- 4%\n- 10em\n-12ex");
    if(result == null)
        return;
    size = result;
    document.getElementById("current__size__block").innerHTML  = size;
}

// Change font
function ChangeFont()
{
    let result = prompt("Введите название шрифта.\n\nПример:\n- Pangolin\n- Verdana");
    if(result == null)
        return;
    font = result;
    document.getElementById("current__font__block").innerHTML = font;
}

// Download image to default folder
function DownloadImage(){
    let downloadLink = document.createElement('a');
    downloadLink.setAttribute('download', 'MyImageLPaint.jpg');
    let dataURL = canvas.toDataURL('image/png');
    let url = dataURL.replace(/^data:image\/png/,'data:application/octet-stream');
    downloadLink.setAttribute('href', url);
    downloadLink.click();
}

// Upload selected image
function UploadImage(e) {
    var dx = 0;
    var arrImg = [];
    var reader = new FileReader;
    reader.onload = function(event) {
        var img = new Image;
        img.onload = function() {
            arrImg.push(img);
            dx = 0;
            arrImg.forEach(function(img) {
                context.drawImage(img, dx, 0);
                dx += img.width;              
            })
        };
        img.src = event.target.result;
    };
    reader.readAsDataURL(e.target.files[0])
};
