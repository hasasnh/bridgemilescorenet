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
/*!***********************************************************************!*\
  !*** ../src/metronic/demo1/js/custom/pages/user-profile/followers.js ***!
  \***********************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTProfileFollowers = function () {
    // init variables
    var showMoreButton = document.getElementById('kt_followers_show_more_button');
    var showMoreCards = document.getElementById('kt_followers_show_more_cards');

    // Private functions
    var handleShowMore = function () {
        // Show more click
        showMoreButton.addEventListener('click', function (e) {
            showMoreButton.setAttribute('data-kt-indicator', 'on');

            // Disable button to avoid multiple click 
            showMoreButton.disabled = true;
            
            setTimeout(function() {
                // Hide loading indication
                showMoreButton.removeAttribute('data-kt-indicator');

                // Enable button
				showMoreButton.disabled = false;

                // Hide button
                showMoreButton.classList.add('d-none');

                // Show card
                showMoreCards.classList.remove('d-none');

                // Scroll to card
                KTUtil.scrollTo(showMoreCards, 200);
            }, 2000);
        });
    }

    // Public methods
    return {
        init: function () {
            handleShowMore();
        }
    }
}();


// On document ready
KTUtil.onDOMContentLoaded(function() {
    KTProfileFollowers.init();
});
/******/ })()
;
//# sourceMappingURL=followers.js.map