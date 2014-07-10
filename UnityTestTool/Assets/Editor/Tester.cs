using System;
using System.Threading;
using NUnit.Framework;

class Tester {

	[TestCase(10,20)]
	public void stor(int input,int output){
		
		plan plan = new plan(input);
		Assert.AreEqual(plan.aa,input);
	}

	[TestCase(new int[]{1,1,0},3)] 
	[TestCase(new int[]{1,1,1},0)] 
	[TestCase(new int[]{0,0,0},1)] 
	[TestCase(new int[]{1,0,0},2)]
	[TestCase(new int[]{1,0,1},2)]
//	[TestCase(new int[]{1,1,0},1)] 
	public void centerTest(int[] input,int output){

		center center = new center();
		center.cells = input;

		Assert.AreEqual(center.GetEmpty(),output);

	}


}
