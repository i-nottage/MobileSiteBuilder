<%@ Page Title="" Language="C#" MasterPageFile="~/MSB.master" AutoEventWireup="true" CodeFile="Application.aspx.cs" Inherits="Application" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
<link rel="stylesheet" href="http://code.jquery.com/ui/1.10.0/themes/base/jquery-ui.css" />
  <script src="http://code.jquery.com/jquery-1.8.3.js"></script>
  <script src="http://code.jquery.com/ui/1.10.0/jquery-ui.js"></script>
  <link rel="stylesheet" href="styles/style.css" />
  <style>
  </style>
  <script>
      var i = 0;
      var ready = false;
      var menuPop = false;

      $(function () {
          $("#downloadLink").hide();
          $("#popupMenu").hide();
          $("#linkDestinationMenu").hide();
          $("#downloadLink").html("Download!");
          $("#mkLink").click(
	function () {
	    $("#linkDestinationMenu").show();
	}
  );
          $("#mkTextBox").click(
		function () {
		    //alert(i);
		    var tmpBox = document.createElement('div');
		    tmpBox.setAttribute("class", "_cBox");
		    tmpBox.setAttribute("id", "_" + i + "");

		    $("#workarea").append(tmpBox);
		    tmpBox.innerHTML = "<div targ=\"_" + i + "\"class=\"trash\"><img class=\"trashIcon\" src=\"trash.png\"/></div><textarea class=\"_cBoxContent\"></textarea>";
		    $("._cBox").resizable();
		    $("._cBox").draggable({ containment: "parent" });
		    i++;
		    $(".trash").click(
				function () {
				    var targ = this.getAttribute("targ");
				    alert(targ);
				    var element = document.getElementById(targ);
				    element.parentNode.removeChild(element);
				}
			);
		}
	);

          $("#save").click(
		function () {
		    if (!ready) {
		        $("#savePrompt").hide();
		        var content = document.getElementById("cur").innerHTML;
		        var uriContent = "data:application/octet-stream," + encodeURIComponent("<html>" + content + "</html>");
		        $("#downloadLink").attr("href", uriContent);
		        var options = {};

		        $("#downloadLink").show("drop", options, 250);
		        ready = true;
		    } else {
		        $("#downloadLink").hide();
		        $("#savePrompt").show("drop", options, 250);
		        ready = false;
		    }
		}
	);

          $("#menuButton").click(
		function () {
		    var options = {};
		    if (menuPop) {
		        $("#popupMenu").hide();
		        menuPop = false;

		    }
		    else {
		        $("#popupMenu").show();
		        menuPop = true;
		    }
		}
	);
      });
  </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<div class="popup" id="popupMenu">
	<ul>
		<li>Save</li>
		<li>Add Text</li>
		<li>Add Link</li>
		<li>Add Image</li>
	</ul>
</div>

<div class="popup" id="linkDestinationMenu">
Where will the link go?
	<ul id="linkChoices">
	</ul>
</div>
<div class="popup" id="menuBar">
	Menu
	<img src="nav-icon.png" id="menuButton">
	</img>
</div>
<div class="popup" id="toolBar">
	<div class="wizardButton" id="save">
			<a id="downloadLink" download="Test.html" href=""> </a>
			<span id="savePrompt">Save?</span>
	</div>
	<div class="wizardButton" id="mkTextBox">
		Add Text
	</div>
	<div class="wizardButton" id="mkLink">
		Add Link
	</div>
</div>
<div id="workarea">
</div>
<script>
    var holder = document.getElementById('workarea'),
    state = document.getElementById('status');
    holder.ondragover = function () { this.className = 'hover'; return false; };
    holder.ondragend = function () { this.className = ''; return false; };
    holder.ondrop = function (e) {
        this.className = '';
        e.preventDefault();
        var file = e.dataTransfer.files[0],
      reader = new FileReader();
        reader.onload = function (event) {
            console.log(event.target);

            // holder.style.background = 'url(' + event.target.result + ') no-repeat center';
            var tmpBox = document.createElement('div');
            var tmpTxt = document.createElement('img');
            tmpBox.setAttribute("class", "_cBox");
            tmpBox.setAttribute("id", "_" + i + "");
            $("#workarea").append(tmpBox);
            //alert(event.target.result);
            //tmpBox.style.background = 'url('+event.target.result+') no-repeat center';
            tmpBox.innerHTML = "<div targ=\"_" + i + "\"class=\"trash\"><img class=\"trashIcon\" src=\"trash.png\"></div><img class=\"_cBoxContent\" src = \"" + event.target.result + "\"></img>";
            $("._cBox").resizable();
            $("._cBox").draggable({ containment: "parent" });
            i++;
            $(".trash").click(
				function () {
				    var targ = this.getAttribute("targ");
				    alert(targ);
				    var element = document.getElementById(targ);
				    element.parentNode.removeChild(element);
				}
			);
        };
        console.log(file);
        reader.readAsDataURL(file);
        return false;
    };
</script>
</body>
</asp:Content>

