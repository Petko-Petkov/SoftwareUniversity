function calcCircleArea () {
	var radius = document.getElementById('radius').value;
	document.body.innerHTML += "<br/>r = " + radius + "; area = " + (Math.PI*Math.pow(radius, 2)) + "<br/>";
}