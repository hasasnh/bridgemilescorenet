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
/*!*******************************************************************************!*\
  !*** ../src/metronic/demo1/js/custom/utilities/modals/create-project/main.js ***!
  \*******************************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTModalCreateProject = function () {
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
			stepper = document.querySelector('#kt_modal_create_project_stepper');
			form = document.querySelector('#kt_modal_create_project_form');

			initStepper();
		},

		getStepperObj: function () {
			return stepperObj;
		},

		getStepper: function () {
			return stepper;
		},
		
		getForm: function () {
			return form;
		}
	};
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
	if (!document.querySelector('#kt_modal_create_project')) {
		return;
	}

	KTModalCreateProject.init();
	KTModalCreateProjectType.init();
	KTModalCreateProjectBudget.init();
	KTModalCreateProjectSettings.init();
	KTModalCreateProjectTeam.init();
	KTModalCreateProjectTargets.init();
	KTModalCreateProjectFiles.init();
	KTModalCreateProjectComplete.init();
});

// Webpack support
if (typeof module !== 'undefined' && typeof module.exports !== 'undefined') {
	window.KTModalCreateProject = module.exports = KTModalCreateProject;
}

/******/ })()
;
//# sourceMappingURL=main.js.map