﻿using UnityEngine;
using System.Collections;

public class BlockRoot : MonoBehaviour {

	private GameObject main_camera = null;
	private BlockControl grabbed_block=null;

	public GameObject BlockPrefab = null;
	public BlockControl[,] blocks;

	// Use this for initialization
	void Start () {
		this.main_camera=GameObject.FindGameObjectWithTag("MainCamera");
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 mouse_position;
		this.unprojectMousePosition(
			out mouse_position,Input.mousePosition);

		Vector2  mouse_position_xy =
			new Vector2(mouse_position.x,mouse_position.y);

		if(this.grabbed_block==null){
			//if(!this.is_has_falling_block()){
			if(Input.GetMouseButtonDown(0)){
				foreach(BlockControl block in this.blocks){
					if(! block.isGrabbable()){
						continue;
					}

					if(!block.isContainedPosition(mouse_position_xy)){
						continue;
					}

					this.grabbed_block=block;
					this.grabbed_block.beginGrab();
					break;
				}
			}
			//}
		}else{

			do{
				BlockControl swap_target =
					this.getNextBlock(grabbed_block,grabbed_block.slide_dir);

				if(swap_target==null){
					break;
				}

				if(! swap_target.isGrabbable()){
					break;
				}

				float offset = this.grabbed_block.calcDirOffset(
					mouse_position_xy,this.grabbed_block.slide_dir);

				if(offset<Block.COLLISION_SIZE/2.0f){
					break;
				}

				this.swapBlock(
					grabbed_block,grabbed_block.slide_dir,swap_target);

				this.grabbed_block = null;

			}while(false);


			if(! Input.GetMouseButton(0)){
				this.grabbed_block.endGrab();
				this.grabbed_block=null;
			}
		}
	}

	public BlockControl getNextBlock(BlockControl block,Block.DIR4 dir){

		BlockControl next_block=null;

		switch(dir){
			case Block.DIR4.RIGHT:
				if(block.i_pos.x<Block.BLOCK_NUM_X-1){
					next_block=this.blocks[block.i_pos.x+1,block.i_pos.y];
				}
				break;
			case Block.DIR4.LEFT:
				if(block.i_pos.x>0){
					next_block=this.blocks[block.i_pos.x-1,block.i_pos.y];
				}
				break;
			case Block.DIR4.UP:
				if(block.i_pos.y< Block.BLOCK_NUM_Y-1){
					next_block=this.blocks[block.i_pos.x,block.i_pos.y+1];
				}
				break;
			case Block.DIR4.DOWN:
				if(block.i_pos.y>0){
					next_block=this.blocks[block.i_pos.x,block.i_pos.y-1];
			}
			break;
		}
		return(next_block);
	}

	public static Vector3 getDirVector(Block.DIR4 dir){

		Vector3 v = Vector3.zero;

		switch(dir){
			case Block.DIR4.RIGHT: v=Vector3.right; break;
			case Block.DIR4.LEFT:  v=Vector3.left;  break;
			case Block.DIR4.UP:    v=Vector3.up;    break;
			case Block.DIR4.DOWN:  v=Vector3.down;  break;
		}

		v *= Block.COLLISION_SIZE;
		return(v);
	}

	public static Block.DIR4 getOppositDir(Block.DIR4 dir){

		Block.DIR4 opposit = dir;

		switch(dir){
			case Block.DIR4.RIGHT: opposit=Block.DIR4.LEFT; break;
			case Block.DIR4.LEFT:  opposit=Block.DIR4.RIGHT;break;
			case Block.DIR4.UP:    opposit=Block.DIR4.DOWN; break;
			case Block.DIR4.DOWN:  opposit=Block.DIR4.UP;   break;
		}
		return(opposit);
	}

	public void swapBlock(
		BlockControl block0, Block.DIR4 dir,BlockControl block1){

		Block.COLOR color0 = block0.color;
		Block.COLOR color1 = block1.color;

		Vector3 scale0 = block0.transform.localScale;
		Vector3 scale1 = block1.transform.localScale;

		float vanish_timer0 = block0.vanish_timer;
		float vanish_timer1 = block1.vanish_timer;

		Vector3 offset0 = BlockRoot.getDirVector(dir);
		Vector3 offset1 = BlockRoot.getDirVector(BlockRoot.getOppositDir(dir));

		block0.setColor(color1);
		block1.setColor(color0);

		block0.transform.localScale = scale1;
		block1.transform.localScale = scale0;

		block0.vanish_timer = vanish_timer1;
		block1.vanish_timer = vanish_timer0;

		block0.beginSlide(offset0);
		block1.beginSlide(offset1);
	}



	public bool unprojectMousePosition(
		out Vector3 world_position, Vector3 mouse_position)

	{
		bool ret;

		Plane plane = new Plane(Vector3.back, new Vector3(
			0.0f,0.0f,-Block.COLLISION_SIZE/2.0f));

		Ray ray = this.main_camera.GetComponent<Camera>().ScreenPointToRay(mouse_position);

		float depth;

		if(plane.Raycast(ray,out depth)){

			world_position=ray.origin+ray.direction*depth;

			ret=true;
		}else{
			world_position=Vector3.zero;
			ret=false;
		}
		return(ret);
	}


	

	public void initialSetUp()
	{
		this.blocks = new BlockControl[Block.BLOCK_NUM_X,Block.BLOCK_NUM_Y];

		int color_index=0;

		for(int y=0; y<Block.BLOCK_NUM_Y; y++){
			for(int x=0;  x<Block.BLOCK_NUM_X; x++){

				GameObject game_object= Instantiate(this.BlockPrefab) as GameObject;

				BlockControl block =game_object.GetComponent<BlockControl>();

				this.blocks[x,y]=block;
				block.i_pos.x=x;
				block.i_pos.y=y;

				block.block_root=this;

				Vector3 position=BlockRoot.calcBlockPosition(block.i_pos);

				block.transform.position=position;
				block.setColor((Block.COLOR)color_index);

				block.name ="block(" + block.i_pos.x.ToString() +"," + block.i_pos.y.ToString() + ")";

				color_index=Random.Range(0,(int)Block.COLOR.NORMAL_COLOR_NUM);
			}
		}
	}

	public static Vector3 calcBlockPosition(Block.iPosition i_pos){

		Vector3 position = new Vector3(-(Block.BLOCK_NUM_X/2.0f -0.5f),
		                               -(Block.BLOCK_NUM_Y/2.0f -0.5f),0.0f);

		       position.x +=(float)i_pos.x * Block.COLLISION_SIZE;
		       position.y +=(float)i_pos.y * Block.COLLISION_SIZE;

		       return (position);
	 }



}
 		

