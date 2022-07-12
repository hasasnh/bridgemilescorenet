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
/*!********************************************************************************!*\
  !*** ../src/metronic/demo1/js/custom/utilities/modals/create-project/files.js ***!
  \********************************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTModalCreateProjectFiles = function () {
	// Variables
	var nextButton;
	var previousButton;
	var form;
	var stepper;

	// Private functions
	var initForm = function() {
		// Project logo
		// For more info about Dropzone plugin visit:  https://www.dropzonejs.com/#usage
		var myDropzone = new Dropzone("#kt_modal_create_project_files_upload", { 
			url: "https://keenthemes.com/scripts/void.php", // Set the url for your upload script location
            paramName: "file", // The name that will be used to transfer the file
            maxFiles: 10,
            maxFilesize: 10, // MB
            addRemoveLinks: true,
            accept: function(file, done) {
                if (file.name == "justinbieber.jpg") {
                    done("Naha, you don't.");
                } else {
                    done();
                }
            }
		});  
	}

	var handleForm = function() {
		nextButton.addEventListener('click', function (e) {
			// Prevent default button action
			e.preventDefault();

			// Disable button to avoid multiple click 
			nextButton.disabled = true;

			// Show loading indication
			nextButton.setAttribute('data-kt-indicator', 'on');

			// Simulate form submission
			setTimeout(function() {
				// Hide loading indication
				nextButton.removeAttribute('data-kt-indicator');

				// Enable button
				nextButton.disabled = false;
				
				// Go to next step
				stepper.goNext();
			}, 1500); 		
		});

		previousButton.addEventListener('click', function () {
			stepper.goPrevious();
		});
	}

	return {
		// Public functions
		init: function () {
			form = KTModalCreateProject.getForm();
			stepper = KTModalCreateProject.getStepperObj();
			nextButton = KTModalCreateProject.getStepper().querySelector('[data-kt-element="files-next"]');
			previousButton = KTModalCreateProject.getStepper().querySelector('[data-kt-element="files-previous"]');

			initForm();
			handleForm();
		}
	};
}();

// Webpack support
if (typeof module !== 'undefined' && typeof module.exports !== 'undefined') {
	window.KTModalCreateProjectFiles = module.exports = KTModalCreateProjectFiles;
}

/******/ })()
;
//# sourceMappingURL=files.js.map