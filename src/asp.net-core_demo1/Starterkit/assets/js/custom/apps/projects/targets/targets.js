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
/*!************************************************************************!*\
  !*** ../src/metronic/demo1/js/custom/apps/projects/targets/targets.js ***!
  \************************************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTProjectTargets = function () {

    var initDatatable = function () {
        const table = document.getElementById('kt_profile_overview_table');

        // set date data order
        const tableRows = table.querySelectorAll('tbody tr');
        tableRows.forEach(row => {
            const dateRow = row.querySelectorAll('td');
            const realDate = moment(dateRow[1].innerHTML, "MMM D, YYYY").format();
            dateRow[1].setAttribute('data-order', realDate);
        });

        // init datatable --- more info on datatables: https://datatables.net/manual/
        const datatable = $(table).DataTable({
            "info": false,
            'order': [],
            "paging": false,
        });

    }

    // Public methods
    return {
        init: function () {
            initDatatable();
        }
    }
}();


// On document ready
KTUtil.onDOMContentLoaded(function() {
    KTProjectTargets.init();
});

/******/ })()
;
//# sourceMappingURL=targets.js.map