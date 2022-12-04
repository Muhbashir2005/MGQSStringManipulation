data = "AfricanJournal";
var f = Encode(data)
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
