function solve (input) {
	var start = parseInt(input[0]);
	var end = parseInt(input[1]);

	var output = '<table>\n<tr><th>Num</th><th>Square</th><th>Fib</th></tr>\n' ;

	for (var i = start; i <= end; i++) {
		var fib = fibonacci(i);
		output += '<tr><td>' + i + '</td><td>' + i*i + '</td><td>' + fib + '</td></tr>\n';
	}

	function fibonacci (num) {
		var first = 0;
		var second = 1;

		for (var j = 1; j <= num; j++){
			var third = first + second;
			if (third === num) {
				return 'yes';
			}
			first = second;
			second = third;
			third = first;
		}

		return 'no';
	}

	output += '</table>';

	console.log(output.trim());
}

solve(['55', '56']);