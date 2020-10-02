"use strict";

/*
   New Perspectives on HTML5, CSS3, and JavaScript 6th Edition
   Tutorial 13
   Case Problem 1

    Author: Matthew Freeman
    Date:   March 03, 2020
   
   Filename: mpl_links.js

*/


window.onload = document.querySelectorAll("#govLinks select").forEach(select => select.onchange = (e) => location.href = e.target.value);
