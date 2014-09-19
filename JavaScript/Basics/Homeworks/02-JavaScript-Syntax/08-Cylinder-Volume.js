function calcCylinderVol (radius, height) {
	var volume = Math.PI*Math.pow(radius, 2)*height;
	return volume.toFixed(3);
}

console.log(calcCylinderVol(2, 4));
console.log(calcCylinderVol(5, 8));
console.log(calcCylinderVol(12, 3));