package com;


import java.util.*;

  public class ArrayListDemo {
	  public static void main(String args[]) {
		  Integer num = 10;
		  String s = "sushmitha";
		  ArrayList<Integer> val = new  ArrayList<>();
		  ArrayList<String> e = new  ArrayList<>();
		  val.add(num);
		  e.add(s);
		  
		  Object o = e.get(0);
		  String si = o.toString();
		  System.out.println(si.length());
		  
	  }
  }
