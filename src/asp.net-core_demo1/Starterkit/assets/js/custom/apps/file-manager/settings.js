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
/*!*********************************************************************!*\
  !*** ../src/metronic/demo1/js/custom/apps/file-manager/settings.js ***!
  \*********************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTAppFileManagerSettings = function () {
    var form;

	// Private functions
	var handleForm = function() {
		const saveButton = form.querySelector('#kt_file_manager_settings_submit');

        saveButton.addEventListener('click', e => {
            e.preventDefault();

            saveButton.setAttribute("data-kt-indicator", "on");

            // Simulate process for demo only
            setTimeout(function(){
                toastr.options = {
                    "closeButton": true,
                    "debug": false,
                    "newestOnTop": false,
                    "progressBar": false,
                    "positionClass": "toast-top-right",
                    "preventDuplicates": false,
                    "showDuration": "300",
                    "hideDuration": "1000",
                    "timeOut": "5000",
                    "extendedTimeOut": "1000",
                    "showEasing": "swing",
                    "hideEasing": "linear",
                    "showMethod": "fadeIn",
                    "hideMethod": "fadeOut"
                };

                toastr.success('File manager settings have been saved');

                saveButton.removeAttribute("data-kt-indicator");
            }, 1000);
        });
	}

	// Public methods
	return {
		init: function(element) {
            form = document.querySelector('#kt_file_manager_settings');

			handleForm();
        }
	};
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    KTAppFileManagerSettings.init();
});

/******/ })()
;
//# sourceMappingURL=settings.js.map