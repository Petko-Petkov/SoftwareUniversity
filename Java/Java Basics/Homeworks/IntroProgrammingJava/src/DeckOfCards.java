/*Write a program to generate a PDF document called Deck-of-Cards.pdf and print in it a standard deck of 
 * 52 cards, following one after another. Each card should be a rectangle holding its face and suit. */
import java.io.FileOutputStream;

import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Document;
import com.itextpdf.text.Font;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.pdf.BaseFont;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;

public class DeckOfCards {

	public static final String result = "DeckOfCards.pdf";
	
	//public static final Font normal = new Font(FontFamily.SYMBOL, 14);
	
	public void createPDF(String filename) {
		String result = "";
		
		char[] suits = new char[]{'\u2663', '\u2666', '\u2665', '\u2660'}; 
		
		try {
			Document document = new Document();
			PdfWriter.getInstance(document, new FileOutputStream(filename));
			document.open();
			
			PdfPTable table = new PdfPTable(4);
			table.setWidthPercentage(100);
			table.getDefaultCell().setFixedHeight(180);
			BaseFont font = BaseFont.createFont("Times.TTF", BaseFont.IDENTITY_H, true);
			Font red = new Font(font, 50, 0, BaseColor.RED);
			Font black = new Font(font, 50, 0, BaseColor.BLACK);
			
			for (int i = 2; i <= 14; i++) {
				
				for (int j = 0; j < suits.length; j++) {
					
					switch (i) {
					case 11: result = "J "; break;
					case 12: result = "Q "; break;
					case 13: result = "K "; break;
					case 14: result = "A "; break;
					default: result = " " + i; break;
					}
					
					switch (j) {
					case 0:
					case 3:	table.addCell(new Paragraph(result + suits[j] + " ", black));
						break;
					case 1:
					case 2:table.addCell(new Paragraph(result + suits[j] + " ", red));
						break;
					}
				}
				
			}
			
			document.add(table);
			document.close();
			
		} catch (Exception e) {
			e.printStackTrace();
		}
		
	}
	
	public static void main(String[] args) {
		new DeckOfCards().createPDF(result);

	}

}
