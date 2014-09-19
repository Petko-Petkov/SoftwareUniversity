function calculate () {
	var result = eval(clearInput());
	document.getElementById('output').innerHTML = result;
}

function clearInput() {
	var input = document.getElementById('input').value;
	var rgx = /^[0-9 \-+/*.()]+$/;
	var match = input.match(rgx);
	return match.join('');
}