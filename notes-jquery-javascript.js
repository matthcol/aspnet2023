// JQuery

// JQuery CSS selector
// all elements with class display-4
$(".display-4")
// the text concatenated from all elements with class display-4
$(".display-4").text()
// idem but only elements h1
$("h1.display-4").text()
// replace text
$("h1.display-4").text("new title")
// text from element by id
$("#special").text()
// element by tag name: <p>
$("p")
// loop
$(".display-4").each(function(i){ console.log(i,$(this))})

// change css
$("h1.display-4").css("background-color", "red")


// read, change, add attribute
$("main a").attr("href")
$("main a").attr("href", "https://www.lequipe.fr")

// add new elements
$("main div").append("<p>new paragraph</p>")

// hide/show
$("main div").css("display", "none")
$("main div").css("display", "block")

$("#ok").click(() => console.log("click"))
$("#ok").on('click',() => console.log("clock"))

// standard JavaScript
document.getElementsByClassName("display-4")
document.getElementsByTagName("p")