"use strict";
exports.__esModule = true;
var meals_1 = require("./meals");
//Checks if the same instance of lunch are prepared for the same customer
function prepareLunch() {
    var l1 = meals_1.Lunch.orderLunch();
    var l2 = meals_1.Lunch.orderLunch();
    if (l1 === l2) {
        console.log('Singleton works, only one instance of lunch is being created!');
    }
    else {
        console.log('Singleton failed, different instances of lunch are being created');
    }
}
prepareLunch();
