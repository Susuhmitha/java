package com;

import java.util.*;

public class ArryListDemo2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String s1="Hyderabad";
		String s2="Pune";
		String s3 = "Noida";
		String s4 = "Kolkatta";
		
		ArrayList list = new ArrayList();
		list.add(s1);
		list.add(s2);
		list.add(s3);
		list.add(s4);
		
		
		for(Object a: list) {
			System.out.println(a.toString());
		}
		
		
		
	}

}

