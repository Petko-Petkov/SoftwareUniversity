/*Write a program to visualize the house and the points from the image above as SVG graphic embedded into a HTML document. */

import java.io.PrintWriter;
import java.util.Scanner;

public class _10PaintHouseAsSVG {
	private static Scanner in;
	//(aX*(bY-cY) + bX*(cY-aY) + cX*(aY-bY))/2;
	public static void main(String[] arg) {
		in = new Scanner(System.in);
		double x = in.nextDouble();
		double y = in.nextDouble();
		// finding triangle area;
		double ax = 17.5;
		double ay = 3.5;
		double bx = 12.5;
		double by = 8.5;
		double cx = 22.5;
		double cy = 8.5;
		double area = Math.abs(ax*(by-cy) + bx*(cy-ay) + cx*(ay-by))/2;
		// finding three new triangle areas
		double areaABP = Math.abs(ax*(by-y) + bx*(y-ay) + x*(ay-by))/2;
		double areaACP = Math.abs(ax*(cy-y) + cx*(y-ay) + x*(ay-cy))/2;
		double areaBPC = Math.abs(bx*(y-cy) + x*(cy-by) + cx*(by-y))/2;
		boolean isInside = (x >= 12.5 && x <= 17.5 && y >= 8.5 && y <= 13.5)
                ||(x >= 20 && x <= 22.5 && y >= 8.5 && y <= 13.5)
                ||(x == 17.5 && y >=3.5 && y <=8.5);
	boolean insideRoof =  (area == areaABP+ areaACP+areaBPC);
	
	in.close();

		

	double pixelsX = 70 + (70 * ((x - 10) / 2.5));
    double pixelsY = 60 + (70 * ((y - 3.5) / 2.5));
        
        // build HTML code
        String content = "<!DOCTYPE html>\n"
                + "<html>\n"
                + "<body>\n"
                + "\n"
                + "<svg width=\"1000\" height=\"1000\">\n"
                + "  <text x=\"55\" y=\"20\" font-size=\"27\">10</text>\n"
                + "  <text x=\"115\" y=\"20\" font-size=\"27\">12.5</text>\n"
                + "  <text x=\"195\" y=\"20\" font-size=\"27\">15</text>\n"
                + "  <text x=\"255\" y=\"20\" font-size=\"27\">17.5</text>\n"
                + "  <text x=\"335\" y=\"20\" font-size=\"27\">20</text>\n"
                + "  <text x=\"395\" y=\"20\" font-size=\"27\">22.5</text>\n"
                + "\n"
                + "  <text x=\"13\" y=\"70\" font-size=\"27\">3.5</text>\n"
                + "  <text x=\"33\" y=\"140\" font-size=\"27\">6</text>\n"
                + "  <text x=\"13\" y=\"210\" font-size=\"27\">8.5</text>\n"
                + "  <text x=\"20\" y=\"280\" font-size=\"27\">11</text>\n"
                + "  <text x=\"0\" y=\"350\" font-size=\"27\">13.5</text>\n"
                + "  <text x=\"20\" y=\"420\" font-size=\"27\">16</text>\n"
                + "\n"
                + "  <line x1=\"53\" y1=\"60\" x2=\"440\" y2=\"60\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"53\" y1=\"130\" x2=\"440\" y2=\"130\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"53\" y1=\"200\" x2=\"440\" y2=\"200\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"53\" y1=\"270\" x2=\"440\" y2=\"270\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"53\" y1=\"340\" x2=\"440\" y2=\"340\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"53\" y1=\"410\" x2=\"440\" y2=\"410\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "\n"
                + "  <line x1=\"70\" y1=\"30\" x2=\"70\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"140\" y1=\"30\" x2=\"140\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"210\" y1=\"30\" x2=\"210\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"280\" y1=\"30\" x2=\"280\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"350\" y1=\"30\" x2=\"350\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "  <line x1=\"420\" y1=\"30\" x2=\"420\" y2=\"440\" stroke-dasharray=\"2, 2\" style=\"stroke:rgb(211,228,244);stroke-width:2\" />\n"
                + "\n";
        
        // add circle
                if(isInside == true && insideRoof == true) {
                    content += "<circle cx=\""+pixelsX+"\" cy=\""+pixelsY+"\" r=\"5\" fill=\"#000000\"!important fill-opacity:0.9\" />\n";
        
        } else {
            content += "<circle cx=\""+pixelsX+"\" cy=\""+pixelsY+"\" r=\"5\" stroke=\"black\" stroke-width=\"1\" fill=\"#bfbfbf\" />\n";
        }
        
        content += "  <polygon points=\"280,60 420,200 140,200\" style=\"fill:#666666;stroke:#002065;stroke-width:2;fill-opacity:0.2\" />\n"
                + "  <rect x=\"140\" y=\"200\" width=\"140\" height=\"140\" style=\"fill:666666;stroke:#002065;stroke-width:2;fill-opacity:0.1\" />\n"
                + "  <rect x=\"350\" y=\"200\" width=\"70\" height=\"140\" style=\"fill:666666;stroke:#002065;stroke-width:2;fill-opacity:0.1\" />\n"
                + "</svg>\n"
                + " \n"
                + "</body>\n"
                + "</html>\n";
        
        try {
            
            // create html file and fill with the html content
            PrintWriter writer = new PrintWriter("house.html", "UTF-8");
            writer.println(content);
            writer.close();

        } catch (Exception e) {
        }
    }
}