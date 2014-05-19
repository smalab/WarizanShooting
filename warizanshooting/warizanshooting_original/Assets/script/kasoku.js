#pragma strict

function Start () {

}

function Update () {
  var y = Input.acceleration.y * 90;
  var x = Input.acceleration.x * 90;
  var z = Input.acceleration.z * 90;
 transform.rotation = Quaternion.Euler(x,y,z);
  
}