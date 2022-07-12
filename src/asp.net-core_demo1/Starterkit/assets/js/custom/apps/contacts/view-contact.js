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
  !*** ../src/metronic/demo1/js/custom/apps/contacts/view-contact.js ***!
  \*********************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTAppContactView = function () {
    // Private functions
    const handleDeleteButton = () => {
        // Select form
        const deleteButton = document.getElementById('kt_contact_delete');

        if (!deleteButton) {
            return;
        }

        deleteButton.addEventListener('click', e => {
            // Prevent default button action
            e.preventDefault();

            // Show popup confirmation 
            Swal.fire({
                text: "Delete contact confirmation",
                icon: "warning",
                buttonsStyling: false,
                showCancelButton: true,
                confirmButtonText: "Yes, delete it!",
                cancelButtonText: "No, return",
                customClass: {
                    confirmButton: "btn btn-danger",
                    cancelButton: "btn btn-active-light"
                }
            }).then(function (result) {
                if (result.value) {
                    Swal.fire({
                        text: "Contact has been deleted!",
                        icon: "success",
                        buttonsStyling: false,
                        confirmButtonText: "Ok, got it!",
                        customClass: {
                            confirmButton: "btn btn-primary"
                        }
                    }).then(function (result) {
                        if (result.value) {
                            // Redirect to customers list page
                            window.location = deleteButton.getAttribute("data-kt-redirect");
                        }
                    });
                } else if (result.dismiss === 'cancel') {
                    Swal.fire({
                        text: "Contact has not been deleted!.",
                        icon: "error",
                        buttonsStyling: false,
                        confirmButtonText: "Ok, got it!",
                        customClass: {
                            confirmButton: "btn btn-primary",
                        }
                    });
                }
            });
        });
    }

    // Public methods
    return {
        init: function () {

            handleDeleteButton();

        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    KTAppContactView.init();
});

/******/ })()
;
//# sourceMappingURL=view-contact.js.map