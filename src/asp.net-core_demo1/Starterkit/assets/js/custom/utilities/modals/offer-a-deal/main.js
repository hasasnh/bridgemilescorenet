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
/*!*****************************************************************************!*\
  !*** ../src/metronic/demo1/js/custom/utilities/modals/offer-a-deal/main.js ***!
  \*****************************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTModalOfferADeal = function () {
    // Private variables
	var stepper;
	var stepperObj;
	var form;	

	// Private functions
	var initStepper = function () {
		// Initialize Stepper
		stepperObj = new KTStepper(stepper);
	}

	return {
		// Public functions
		init: function () {
			stepper = document.querySelector('#kt_modal_offer_a_deal_stepper');
			form = document.querySelector('#kt_modal_offer_a_deal_form');

			initStepper();
		},

		getStepper: function () {
			return stepper;
		},

		getStepperObj: function () {
			return stepperObj;
		},
		
		getForm: function () {
			return form;
		}
	};
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
	if (!document.querySelector('#kt_modal_offer_a_deal')) {
		return;
	}

    KTModalOfferADeal.init();
    KTModalOfferADealType.init();
    KTModalOfferADealDetails.init();
    KTModalOfferADealFinance.init();
    KTModalOfferADealComplete.init();
});

// Webpack support
if (typeof module !== 'undefined' && typeof module.exports !== 'undefined') {
	window.KTModalOfferADeal = module.exports = KTModalOfferADeal;
}
/******/ })()
;
//# sourceMappingURL=main.js.map