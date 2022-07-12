/******/ (() => { // webpackBootstrap
/******/ 	"use strict";
/******/ 	// The require scope
/******/ 	var __webpack_require__ = {};
/******/ 	
/************************************************************************/
/******/ 	/* webpack/runtime/make namespace object */
/******/ 	(() => {
/******/ 		// define __esModule on exports
/******/ 		__webpack_require__.r = (exports) => {
/******/ 			if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 				Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 			}
/******/ 			Object.defineProperty(exports, '__esModule', { value: true });
/******/ 		};
/******/ 	})();
/******/ 	
/************************************************************************/
var __webpack_exports__ = {};
/*!************************************************************!*\
  !*** ../src/metronic/demo1/js/custom/pages/general/pos.js ***!
  \************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTPosSystem = function () {
	var form;

    var moneyFormat = wNumb({
        mark: '.',
        thousand: ',',
        decimals: 2,
        prefix: '$',
    });

	var calculateTotals = function() {
        var items = [].slice.call(form.querySelectorAll('[data-kt-pos-element="item-total"]'));
        var total = 0;
        var tax = 12;
        var discount = 8;
        var grantTotal = 0;

        items.map(function (item) {
            total += moneyFormat.from(item.innerHTML);
        });

        grantTotal = total;
        grantTotal -= discount;
        grantTotal += tax * 8 / 100;

        form.querySelector('[data-kt-pos-element="total"]').innerHTML = moneyFormat.to(total); 
        form.querySelector('[data-kt-pos-element="grant-total"]').innerHTML = moneyFormat.to(grantTotal); 
    }

	var handleQuantity = function() {
		var dialers = [].slice.call(form.querySelectorAll('[data-kt-pos-element="item"] [data-kt-dialer="true"]'));

        dialers.map(function (dialer) {
            var dialerObject = KTDialer.getInstance(dialer);

            dialerObject.on('kt.dialer.changed', function(){
                var quantity = parseInt(dialerObject.getValue());
                var item = dialerObject.getElement().closest('[data-kt-pos-element="item"]');
                var value = parseInt(item.getAttribute("data-kt-pos-item-price"));
                var total = quantity * value;

                item.querySelector('[data-kt-pos-element="item-total"]').innerHTML = moneyFormat.to(total);

                calculateTotals();
            });    
        });
	}

	return {
		// Public functions
		init: function () {
			// Elements
			form = document.querySelector('#kt_pos_form');

			handleQuantity();
		}
	};
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
	KTPosSystem.init();
});
/******/ })()
;
//# sourceMappingURL=pos.js.map