console.log("Decoding, currently not available");
var data = "I am now a boy in university ";
var f = Encode(data);
console.log(f);
function Encode(data){
  data[0];
	var a = data.substring(0, data.length/2);
	var b = data.substring(data.length/2, data.length);
	var k = "";
	var l = "";

	for (let i = 0; i < a.length; i++) {
    if (i%2 == 0) {
        k += a[i];
        k += b[i];  
    }
    if (i%2 != 0) {
        l += a[i];
        l += b[i];
    }
	}
  console.log(l + k);
}  
// function Decode(data){
//   var c = data.substring(0, data.length/2 - 1);
// 	var d = data.substring(data.length/2 -1, data.length);
//   var h = "";
//   var g = "";
//   for (let j = 0; j < c.length; j++) {
//     if (j%2 != 0) {
//       h += d[j];
//       h += c[j];
//     }
//     if (j%2 == 0) {
//       g += d[j];
//       g += c[j];
//     }
//   }
//   console.log(h);
//   console.log(g);
// }
