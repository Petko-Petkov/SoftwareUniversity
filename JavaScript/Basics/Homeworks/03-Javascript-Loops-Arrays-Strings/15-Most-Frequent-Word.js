function findMostFreqWord (input) {
	var str = input.toLowerCase();
	var separator = (/[^a-z]+/);
	var arr = str.split(separator).filter(Boolean);
	var output = [];
	var maxAprnce = 0;
	for (var i in arr) {
		var word = arr[i];

		if (output[word] === undefined) {
			output[word] = {word: word, times: 1};
		} else{
			output[word].times++;
		}

		if (output[word].times > maxAprnce) {
			maxAprnce = output[word].times;
		}

		var maxApprncsWord = [];
	}


	for (var id in output) {
		if (output[id].times === maxAprnce) {
			console.log(id + ' -> ' + output[id].times);
		}
	}
}

findMostFreqWord('in the middle of the night');
//findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.');
//findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');
