	function findPalindromes (value) {
		var str = value.replace(/[^\w\s]/gi, '');
		var arr = str.split(' ');
		var palindromes = [];
		
		for (var i = 0; i < arr.length; i++) {
			var tmp = arr[i];

			if (tmp.toLowerCase() === tmp.toLowerCase().split('').reverse().join('')) {
				palindromes.push(tmp);
			}
		}

		return palindromes;
	}

	console.log(findPalindromes('There is a man, his name was Bob.'));