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
/*!*********************************************************!*\
  !*** ../src/metronic/demo1/js/custom/apps/chat/chat.js ***!
  \*********************************************************/
__webpack_require__.r(__webpack_exports__);


// Class definition
var KTAppChat = function () {
	// Private functions
	var handeSend = function (element) {
		if (!element) {
			return;
		}

		// Handle send
		KTUtil.on(element, '[data-kt-element="input"]', 'keydown', function(e) {
			if (e.keyCode == 13) {
				handeMessaging(element);
				e.preventDefault();

				return false;
			}
		});

		KTUtil.on(element, '[data-kt-element="send"]', 'click', function(e) {
			handeMessaging(element);
		});
	}

	var handeMessaging = function(element) {
		var messages = element.querySelector('[data-kt-element="messages"]');
		var input = element.querySelector('[data-kt-element="input"]');

        if (input.value.length === 0 ) {
            return;
        }

		var messageOutTemplate = messages.querySelector('[data-kt-element="template-out"]');
		var messageInTemplate = messages.querySelector('[data-kt-element="template-in"]');
		var message;
		
		// Show example outgoing message
		message = messageOutTemplate.cloneNode(true);
		message.classList.remove('d-none');
		message.querySelector('[data-kt-element="message-text"]').innerText = input.value;		
		input.value = '';
		messages.appendChild(message);
		messages.scrollTop = messages.scrollHeight;
		
		
		setTimeout(function() {			
			// Show example incoming message
			message = messageInTemplate.cloneNode(true);			
			message.classList.remove('d-none');
			message.querySelector('[data-kt-element="message-text"]').innerText = 'Thank you for your awesome support!';
			messages.appendChild(message);
			messages.scrollTop = messages.scrollHeight;
		}, 2000);
	}

	// Public methods
	return {
		init: function(element) {
			handeSend(element);
        }
	};
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
	// Init inline chat messenger
    KTAppChat.init(document.querySelector('#kt_chat_messenger'));

	// Init drawer chat messenger
	KTAppChat.init(document.querySelector('#kt_drawer_chat_messenger'));
});

/******/ })()
;
//# sourceMappingURL=chat.js.map