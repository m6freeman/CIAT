"use strict";

/*
   New Perspectives on HTML5, CSS3, and JavaScript 6th Edition
   Tutorial 11
   Case Problem 1

    Author: Matthew Freeman
    Date:   February 25, 2020
   
   Filename: bw_review.js
	
   Functions List:

   init()
      Initializes the contents of the web page and sets up the
      event handlers.
      
   lightStars(e)
      Function that colors the stars representing the user rating
      for the book.
      
   turnOffStars(e)
      Function that restores the stars to empty colors, removing
      the user rating for the book.

   updateCount()
      Updates the count of characters in the wordCountBox
      element.

   countCharacters(textStr)
      Returns the number of a non-whitespace characters
      within textStr

*/

window.onload = init();


function init() {
   
   var stars = document.querySelectorAll("span#stars img");

   stars.forEach(star => {
      star.style.cursor = "pointer";
      var turnOn = () => { lightStars(star, stars)};
      star.addEventListener("mouseover",  turnOn);
      var turnOff = () =>{ turnOffStars(stars)};
      star.addEventListener("mouseout", turnOff);
      star.addEventListener("click", () => { star.removeEventListener("mouseout", turnOff);});
   });

   document.getElementById("comment").addEventListener("keyup", updateCount);
}

function lightStars(star, allStars) {
   var starNumber = star.alt;
   for (let index = 0; index < starNumber; index++) {
      allStars[index].src = "bw_star2.png";
   }
   for (let index = starNumber; index < 5; index++) {
      allStars[index].src = "bw_star.png";
   }

   document.getElementById("rating").value = starNumber + " stars";
}

function turnOffStars(allStars) {
   allStars.forEach(star => {
      star.src = "bw_star.png";
   });

   document.getElementById("rating").value = "";
}
  
function updateCount(params) {
   var commentText = document.getElementById("comment").value;
   var charCount = countCharacters(commentText);
   var wordCountBox = document.getElementById("wordCount");
   wordCountBox.value = charCount + " / 1000";
   if (charCount > 1000) {
      wordCountBox.style.backgroundColor = "red";
      wordCountBox.style.color = "white";
   } else {
      wordCountBox.style.backgroundColor = "white";
      wordCountBox.style.color = "black";
   }
}  
  
/*=================================================================*/

function countCharacters(textStr) {
   var commentregx = /\s/g;
   var chars = textStr.replace(commentregx, "");
   return chars.length;
}   