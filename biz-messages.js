		
		// Scripts only need to be included inside of popup windows
		// adds animation to show the message, and allows it to be closed
		
		function setupBizMessages() {
			$("DIV.popMasterWrap .bizFailure, DIV.popMasterWrap .bizSuccess").slideDown(800);
			$("DIV.popMasterWrap .bizMessageClose a").click(function () {
				$("DIV.popMasterWrap .bizFailure, DIV.popMasterWrap .bizSuccess").slideUp(500);
				return false;
			});
		}

		$(function () { 
			setupBizMessages();
		}); 