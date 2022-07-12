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
  !*** ../src/metronic/demo1/js/custom/utilities/search/horizontal.js ***!
  \**********************************************************************/
__webpack_require__.r(__webpack_exports__);

 
// Class definition
var KTSearchHorizontal = function () {
    // Private functions
    var initAdvancedSearchForm = function () {
       var form = document.querySelector('#kt_advanced_search_form');

       // Init tags
       var tags = form.querySelector('[name="tags"]');
       new Tagify(tags);
    }

    var handleAdvancedSearchToggle = function () {
        var link = document.querySelector('#kt_horizontal_search_advanced_link');

        link.addEventListener('click', function (e) {
            e.preventDefault();
            
            if (link.innerHTML === "Advanced Search") {
                link.innerHTML = "Hide Advanced Search";
            } else {
                link.innerHTML = "Advanced Search";
            }
        })
    }

    // Public methods
    return {
        init: function () {
            initAdvancedSearchForm();
            handleAdvancedSearchToggle();
        }
    }     
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    KTSearchHorizontal.init();
});

/******/ })()
;
//# sourceMappingURL=horizontal.js.map