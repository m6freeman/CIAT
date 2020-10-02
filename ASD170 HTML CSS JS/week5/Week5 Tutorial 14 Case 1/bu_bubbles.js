"use strict";

/*
   New Perspectives on HTML5, CSS3, and JavaScript 6th Edition
   Tutorial 14
   Case Problem 1

    Author: Matthew Freeman
    Date:   March 9, 2020
   
   Filename: bu_bubbles.js

*/

var box = {
   width: 1024,
   height: 500
}

function bubble(size, img) {
   this.radius = size;
   this.imageURL = img;
   this.xVelocity = null;
   this.yVelocity = null;
   this.xPos = null;
   this.yPos = null;
   this.opacity = 1;
   this.rotateDirection = 1;
   this.hue = 0;
   this.rotate = 0;
   
}

bubble.prototype.fadeBubble = function() { this.opacity -= 0.0005; };
bubble.prototype.changeColor = function() { this.hue = (this.hue + 3) % 360; };
bubble.prototype.rotateBubble = function() { this.rotate = (this.rotate + this.rotateDirection) % 360; };
bubble.prototype.moveBubble = function(height, width) {
   let bubbleTop = this.yPos;
   let bubbleBottom = this.yPos + this.radius;
   let bubbleLeft = this.xPos;
   let bubbleRight = this.xPos + this.radius;

   if (bubbleTop < 0 || bubbleBottom > height) { this.yVelocity = -this.yVelocity; }
   if (bubbleLeft < 0 || bubbleRight > width) { this.xVelocity = -this.xVelocity; }
   this.xPos += this.xVelocity;
   this.yPos += this.yVelocity;
};


window.addEventListener("load", () => {
   // Reference to the bubble box
   var bubbleBox = document.getElementById("bubbleBox");
   
   // Create a new bubble every half-second
   setInterval(() => {
      
      // Do not create more than 20 bubbles at any one time
      if (bubbleBox.childElementCount < 20) {  
         //instantiate a new bubble object
         let newBubble = new bubble(randInt(50, 120), "bu_bubble" + randInt(1, 10) + ".png");
         newBubble.xPos = box.width / 2;
         newBubble.yPos = box.height / 2;
         newBubble.xVelocity = randInt(-5, 5);
         newBubble.yVelocity = randInt(-5, 5);
         newBubble.rotate = randInt(0, 360);
         newBubble.hue = randInt(0, 360);
         newBubble.rotateDirection = randInt(-2, 2);

         //create html <img> with settings and add to bubbleBox
         let bubbleImg = document.createElement("img");
         bubbleImg.style.position = "absolute";
         bubbleImg.src = newBubble.imageURL;
         bubbleImg.style.width = newBubble.radius + "px";
         bubbleImg.style.left = newBubble.xPos + "px";
         bubbleImg.style.top = newBubble.yPos + "px";
         bubbleBox.appendChild(bubbleImg);

         let bubbleInterval = setInterval(() => {
            newBubble.fadeBubble();
            if (newBubble.opacity <= 0) {
               bubbleBox.removeChild(bubbleImg);
               clearInterval(bubbleInterval);
            }
            bubbleImg.style.opacity = newBubble.opacity;
            newBubble.changeColor();
            bubbleImg.style.filter = "hue-rotate(" + newBubble.hue + "deg)";
            newBubble.rotateBubble();
            bubbleImg.style.transform = "rotate(" + newBubble.rotate + "deg)";
            newBubble.moveBubble(box.height, box.width);
            bubbleImg.style.top = newBubble.yPos + "px";
            bubbleImg.style.left = newBubble.xPos + "px";
            
         }, 25);
      }
   }, 500);

   /* Function to return a random integer between minVal and maxValue inclusive */
   function randInt(minVal, maxVal) {
      let size = maxVal - minVal + 1;
      return Math.floor(minVal + size * Math.random());
   }  

});