package com;
import java.io.*;


public class FileDemo {
 public void readDatafromFile() {
	 File file1 = new File("src/com/Private.java");
	 
	 FileInputStream fis=null;
	 BufferedInputStream bis=null;
	 StringBuilder content= new StringBuilder();
	 int data;
	 
	 try {
		 fis = new FileInputStream(file1);
		 bis=new BufferedInputStream(fis);
		 
		 while((data = bis.read()) != -1) {
			 content.append((char)data);
		 }
		 System.out.println(content);
	 }
	 catch(FileNotFoundException fe) {
		 System.out.println("File not found");
	 }
	 catch(IOException e) {
		 e.printStackTrace();
	 }
	 finally {
		 if(bis!=null) {
			 try {
				 bis.close();
			 }
			 catch(IOException ie) {
				 ie.printStackTrace();
			 }
		 }
	 }
	 
 }
}
			 
			 
			 
 
