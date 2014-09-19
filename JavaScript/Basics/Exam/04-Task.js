function solve (input) {
	var concertProgram = {};

	for (var i = 0; i < input.length; i++) {
		var tempRow = input[i].split('|').filter(Boolean);

		var town = tempRow[1].trim();
		var band = tempRow[0].trim();
		var venue = tempRow[3].trim();

		if (!(town in concertProgram)) {
			concertProgram[town] = {};
			if (!(venue in concertProgram[town])){
				concertProgram[town][venue] = {};
				if (!(band in concertProgram[town][venue])) {
					concertProgram[town][venue][band] = 1;
				}
			} 
		}

	}
	

	var towns = [];

	for (var id in concertProgram) {
		if (concertProgram.hasOwnProperty(id)) {
			towns.push(id);
		}
	}

	towns.sort();

	for (var j = 0; j < towns.length; j++) {
		var venues = [];
		var bands = [];
		var output = '';

		for (var cita in towns) {
			if ((concertProgram[towns[j]].hasOwnProperty(cita))) {
				venues.push(cita);
				bands.push(concertProgram[towns[j]][cita]);
			}
		}
		venues.sort();
		bands.sort();
	}

	console.log(concertProgram);
	//console.log(concertProgram[town]);
}

solve(['ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
	'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
	'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
	'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
	'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
	'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
	'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
	'Helloween | London | 28-Jul-2014 | Wembley Stadium',
	'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
	'Metallica | London | 03-Oct-2014 | Olympic Stadium',
	'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
	'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium']
	);