"use strict";
exports.__esModule = true;
exports.Lunch = void 0;
var Lunch = /** @class */ (function () {
    function Lunch() {
    }
    /**
     * Private constructor method to controll the creation of class instances
     */
    Lunch._hasAlreadyTakenLunch = function () {
        return Lunch.takenLunch == null;
    };
    Lunch.orderLunch = function () {
        if (!Lunch._hasAlreadyTakenLunch) {
            Lunch.takenLunch = new Lunch();
        }
        return Lunch.takenLunch;
    };
    return Lunch;
}());
exports.Lunch = Lunch;
