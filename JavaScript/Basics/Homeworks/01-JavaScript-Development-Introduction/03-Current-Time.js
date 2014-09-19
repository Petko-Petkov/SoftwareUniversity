var date = new Date();
var hours = date.getHours();
var minutes = date.getMinutes();
var dateTime = "";

if (minutes < 10)
	{minutes = "0" + minutes};

dateTime = hours + ":" + minutes;
console.log(dateTime);