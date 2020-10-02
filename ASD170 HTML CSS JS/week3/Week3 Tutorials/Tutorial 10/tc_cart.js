"use strict";

/*
   New Perspectives on HTML5 and CSS3, 7th Edition
   Tutorial 10
   Case Problem 1
   
    Author: Matthew Freeman
    Date:   February 24, 2020
   
   Filename: tc_cart.js
	
*/

var orderTotal = 0;
var cartHTML = "<table><tr><th>Item</th><th>Description</th><th>Price</th><th>Qty</th><th>Total</th></tr>";

for (let index = 0; index < item.length; index++) {
   const element = item[index];
   cartHTML += "<tr><td><img src='tc_" + element + ".png' alt='" + element + "' /></td >";
   cartHTML += "<td>" + itemDescription[index] + "</td>" + 
               "<td>$" + itemPrice[index] + "</td>" +
               "<td>" + itemQty[index] + "</td>";
   var itemCost = itemPrice[index] * itemQty[index];
   cartHTML += "<td>$" + itemCost + "</td></tr>";
   orderTotal += itemCost;
}
cartHTML += "<tr><td colspan = '4'>Subtotal</td><td>$" + orderTotal + "</td></tr></table>";

document.getElementById("cart").innerHTML = cartHTML;