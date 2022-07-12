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
/*!******************************************************************************************!*\
  !*** ../src/metronic/demo1/js/custom/apps/ecommerce/customers/details/payment-method.js ***!
  \******************************************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTCustomerViewPaymentMethod = function () {

    // Private functions
    var initPaymentMethod = function () {
        // Define variables
        const table = document.getElementById('kt_customer_view_payment_method');
        const tableRows = table.querySelectorAll('[ data-kt-customer-payment-method="row"]');

        tableRows.forEach(row => {
            // Select delete button
            const deleteButton = row.querySelector('[data-kt-customer-payment-method="delete"]');

            // Delete button action
            deleteButton.addEventListener('click', e => {
                e.preventDefault();

                // Popup confirmation
                Swal.fire({
                    text: "Are you sure you would like to delete this card?",
                    icon: "warning",
                    showCancelButton: true,
                    buttonsStyling: false,
                    confirmButtonText: "Yes, delete it!",
                    cancelButtonText: "No, return",
                    customClass: {
                        confirmButton: "btn btn-primary",
                        cancelButton: "btn btn-active-light"
                    }
                }).then(function (result) {
                    if (result.value) {
                        row.remove();
                        modal.hide(); // Hide modal				
                    } else if (result.dismiss === 'cancel') {
                        Swal.fire({
                            text: "Your card was not deleted!.",
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
        });
    }

    // Handle set as primary button
    const handlePrimaryButton = () => {
        // Define variable
        const button = document.querySelector('[data-kt-payment-mehtod-action="set_as_primary"]');

        button.addEventListener('click', e => {
            e.preventDefault();

            // Popup confirmation
            Swal.fire({
                text: "Are you sure you would like to set this card as primary?",
                icon: "warning",
                showCancelButton: true,
                buttonsStyling: false,
                confirmButtonText: "Yes, set it!",
                cancelButtonText: "No, return",
                customClass: {
                    confirmButton: "btn btn-primary",
                    cancelButton: "btn btn-active-light"
                }
            }).then(function (result) {
                if (result.value) {
                    Swal.fire({
                        text: "Your card was set to primary!.",
                        icon: "success",
                        buttonsStyling: false,
                        confirmButtonText: "Ok, got it!",
                        customClass: {
                            confirmButton: "btn btn-primary",
                        }
                    });
                } else if (result.dismiss === 'cancel') {
                    Swal.fire({
                        text: "Your card was not set to primary!.",
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
    };

    // Public methods
    return {
        init: function () {
            initPaymentMethod();
            handlePrimaryButton();
        }
    }
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    KTCustomerViewPaymentMethod.init();
});
/******/ })()
;
//# sourceMappingURL=payment-method.js.map