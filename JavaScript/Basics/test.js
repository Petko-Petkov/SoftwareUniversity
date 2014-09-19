function draw (){
			var ctx = document.getElementById('my-canvas').getContext('2d');
			alert(ctx.canvas.id +" | " + ctx.canvas.width);
			ctx.fillRect(20, 20, 100, 100);
			ctx.fillStyle = #555;
		}