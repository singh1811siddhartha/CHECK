var express = require(express);
var app = express();

app.get("/",function(req,resp){
    resp.send("hello World");
})

app.listen(4000);
console.log("Server is running at port 4000");