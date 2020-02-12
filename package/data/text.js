var config = require("./config.json");
var Twit = require('twit');
var fs = require('fs');
 
var T = new Twit({
  consumer_key:         config[0],
  consumer_secret:      config[1],
  access_token:         config[2],
  access_token_secret:  config[3],
  timeout_ms:           60*1000,  // optional HTTP request timeout to apply to all requests.
  strictSSL:            true,     // optional - requires SSL certificates to be valid.
})
var fs = require('fs'),
    path = require('path'),    
    filePath = path.join(__dirname, '\content.tweet');

fs.readFile(filePath, {encoding: 'utf-8'}, function(fileerr,filedata){
    if (!fileerr) {
        //console.log('received data: ' + data);
        T.post('statuses/update', { status: filedata }, function(err, data, response) {
		  console.log("https://twitter.com/"+data.user.screen_name+"/status/"+data.id_str)
		})
    } else {
        console.log(fileerr);
    }
});
