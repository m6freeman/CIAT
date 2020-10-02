"use strict";

/*
   New Perspectives on HTML5, CSS3, and JavaScript 6th Edition
   Tutorial 13
   Review Assignment

   Shopping Cart Form Script
   
    Author: Matthew Freeman
    Date:   March 3, 2020
   
   Filename: co_cart.js
   
   Function List
   =============
   
   calcCart()
      Calculates the cost of the customer order
      
   formatNumber(val, decimals)
      Format a numeric value, val, using the local
      numeric format to the number of decimal
      places specified by decimals
      
   formatUSACurrency(val)
      Formats val as U.S.A. currency
   
*/ 


window.addEventListener("load", () => {
   calcCart();
   document.getElementById("modelQty").onchange = calcCart;
   document.getElementsByName("shipping").forEach(input => input.onclick = calcCart);
})

function calcCart() {
   var modelCostElement = document.getElementById("modelCost");
   var modelQtyElement = document.getElementById("modelQty");
   var shipChoice;
   document.getElementsByName("shipping").forEach(element => { if (element.checked) shipChoice = element;});
   var orderCost = modelCostElement.value * modelQtyElement.options[modelQtyElement.selectedIndex].value;
   var shipCost = shipChoice.value * modelQtyElement.options[modelQtyElement.selectedIndex].value;
   var salesTax = 0.05 * (orderCost + shipCost);
   document.getElementById("shippingCost").value = formatNumber(shipCost, 2);
   document.getElementById("subTotal").value = formatUSCurrency(orderCost + shipCost);
   document.getElementById("orderCost").value = formatUSCurrency(orderCost);
   document.getElementById("salesTax").value = formatUSCurrency(salesTax);
   document.getElementById("cartTotal").value = formatUSCurrency(orderCost + shipCost + salesTax);
   document.getElementById("shippingType").value = shipChoice.parentElement.innerText;
}

function formatNumber(val, decimals) {
   return val.toLocaleString(undefined, {minimumFractionDigits: decimals, 
                                         maximumFractionDigits: decimals});
}

function formatUSCurrency(val) {
   return val.toLocaleString('en-US', {style: "currency", currency: "USD"} );
}
