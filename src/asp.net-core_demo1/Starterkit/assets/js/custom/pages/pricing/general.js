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
/*!****************************************************************!*\
  !*** ../src/metronic/demo1/js/custom/pages/pricing/general.js ***!
  \****************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTPricingGeneral = function () {
    // Private variables
    var element;
	var planPeriodMonthButton;
	var planPeriodAnnualButton;

	var changePlanPrices = function(type) {
		var items = [].slice.call(element.querySelectorAll('[data-kt-plan-price-month]'));

		items.map(function (item) {
			var monthPrice = item.getAttribute('data-kt-plan-price-month');
			var annualPrice = item.getAttribute('data-kt-plan-price-annual');

			if ( type === 'month' ) {
				item.innerHTML = monthPrice;
			} else if ( type === 'annual' ) {
				item.innerHTML = annualPrice;
			}
		});
	}

    var handlePlanPeriodSelection = function(e) {

        // Handle period change
        planPeriodMonthButton.addEventListener('click', function (e) {
            e.preventDefault();

            planPeriodMonthButton.classList.add('active');
            planPeriodAnnualButton.classList.remove('active');

            changePlanPrices('month');
        });

		planPeriodAnnualButton.addEventListener('click', function (e) {
            e.preventDefault();

            planPeriodMonthButton.classList.remove('active');
            planPeriodAnnualButton.classList.add('active');
            
            changePlanPrices('annual');
        });
    }

    // Public methods
    return {
        init: function () {
            element = document.querySelector('#kt_pricing');
			planPeriodMonthButton = element.querySelector('[data-kt-plan="month"]');
			planPeriodAnnualButton = element.querySelector('[data-kt-plan="annual"]');

            // Handlers
            handlePlanPeriodSelection();
        }
    }
}();

// On document ready
KTUtil.onDOMContentLoaded(function() {
    KTPricingGeneral.init();
});

/******/ })()
;
//# sourceMappingURL=general.js.map