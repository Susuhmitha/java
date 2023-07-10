package com;

public class Throw {
	public static void main(String[] args) throws Balance {
		// TODO Auto-generated method stub
		try {
		int total = 100;
		int wd = 50;
		int rem = total - wd;
		if(wd > total || rem<=0) {
		throw new Balance("less ammout");
		}
		else {
			System.out.println(rem);
		}
		}
		catch(Balance b) {
			System.out.println(b.getMessage());
			
			
		}

}
}