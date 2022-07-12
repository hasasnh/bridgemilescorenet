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
/*!*********************************************************************************!*\
  !*** ../src/metronic/demo1/js/custom/utilities/modals/offer-a-deal/complete.js ***!
  \*********************************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTModalOfferADealComplete = function () {
	// Variables
	var startButton;
	var form;
	var stepper;

	// Private functions
	var handleForm = function() {
		startButton.addEventListener('click', function () {
			stepper.goTo(1);
		});
	}

	return {
		// Public functions
		init: function () {
			form = KTModalOfferADeal.getForm();
			stepper = KTModalOfferADeal.getStepperObj();
			startButton = KTModalOfferADeal.getStepper().querySelector('[data-kt-element="complete-start"]');

			handleForm();
		}
	};
}();

// Webpack support
if (typeof module !== 'undefined' && typeof module.exports !== 'undefined') {
	window.KTModalOfferADealComplete = module.exports = KTModalOfferADealComplete;
}
/******/ })()
;
//# sourceMappingURL=complete.js.map