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
/*!**********************************************************************!*\
  !*** ../src/metronic/demo1/js/custom/utilities/modals/share-earn.js ***!
  \**********************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTModalShareEarn = function () {
    // Private functions
    var handleForm = function() {
        var button = document.querySelector('#kt_share_earn_link_copy_button');
        var input = document.querySelector('#kt_share_earn_link_input');
        var clipboard = new ClipboardJS(button);

        if (!clipboard) {
            return;
        }

        //  Copy text to clipboard. For more info check the plugin's documentation: https://clipboardjs.com/
        clipboard.on('success', function(e) {
            var buttonCaption = button.innerHTML;
            //Add bgcolor
            input.classList.add('bg-success');
            input.classList.add('text-inverse-success');

            button.innerHTML = 'Copied!';

            setTimeout(function() {
                button.innerHTML = buttonCaption;

                // Remove bgcolor
                input.classList.remove('bg-success'); 
                input.classList.remove('text-inverse-success'); 
            }, 3000);  // 3seconds

            e.clearSelection();
        });
    }

    // Public methods
    return {
        init: function () {
            handleForm();
        }
    }
}();

// On document ready
KTUtil.onDOMContentLoaded(function() {
    KTModalShareEarn.init();
});

/******/ })()
;
//# sourceMappingURL=share-earn.js.map