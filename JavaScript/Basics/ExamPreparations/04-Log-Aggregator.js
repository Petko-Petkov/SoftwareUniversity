function solve (input) {
	var n = input[0];
	var assArr = {};
	for (var i = 0; i < n; i++) {
		var tempRow = input[i+1].split(' ');

		var user = tempRow[1];
		var ip = tempRow[0];
		var minutes = parseInt(tempRow[2], 2);

		if (!(user in assArr)) {
			assArr[user] = {};
			assArr[user][ip] = minutes;
		} else if ((user in assArr) && !(ip in assArr[user])) {
			assArr[user][ip] = minutes;
		} else {
			assArr[user][ip] += minutes;
		}
	}

	var userKeys = [];
	for (var userKey in assArr) {
		if (assArr.hasOwnProperty(userKey)) {
			userKeys.push(userKey);
		}
	}

	userKeys.sort();
	var output = '';

	for (var j = 0; j < userKeys.length; j++) {
		var useIpKeys = [];
		var sumMinutes = 0;


		for (var id in userKeys) {
			if (assArr[userKeys[j]].hasOwnProperty(id)) {
				useIpKeys.push(id);
				sumMinutes += assArr[userKeys[j]][id];
			}
		}

		output += userKeys[j] + ': ' + sumMinutes + ' [' + useIpKeys.join(', ') + ']\n';
		console.log(output);
	}

	return output;
}

solve([
	'2',
	'84.238.140.178 nakov 25',
	'84.238.140.178 nakov 35' ]);

solve([
	'7',
	'192.168.0.11 peter 33',
	'10.10.17.33 alex 12',
	'10.10.17.35 peter 30',
	'10.10.17.34 peter 120',
	'10.10.17.34 peter 120',
	'212.50.118.81 alex 46',
	'212.50.118.81 alex 4']);