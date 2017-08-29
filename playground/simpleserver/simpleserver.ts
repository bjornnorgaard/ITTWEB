var http = require('http');
var port = process.env.PORT || 3000;
var server = http.createServer(function(req, res){
    res.writeHead(200, {'content-type': 'text/plain'});
    req.end('Hello world!\n');
});

server.listen(port);
console.log('Server is running');
