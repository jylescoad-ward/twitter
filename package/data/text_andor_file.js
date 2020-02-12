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
		var b64content = fs.readFileSync(process.argv[2], { encoding: 'base64' })
		 
		// first we must post the media to Twitter
		T.post('media/upload', { media_data: b64content }, function (err, data, response) {
		  // now we can assign alt text to the media, for use by screen readers and
		  // other text-based presentations and interpreters
		  var mediaIdStr = data.media_id_string
		  var altText = "jyles.club uploaded media"
		  var meta_params = { media_id: mediaIdStr, alt_text: { text: altText } }
		 
		  T.post('media/metadata/create', meta_params, function (err, data, response) {
			if (!err) {
			  // now we can reference the media and post a tweet (media will attach to the tweet)
			  var params = { status: filedata, media_ids: [mediaIdStr] }
		 
			  T.post('statuses/update', params, function (err, data, response) {
				console.log("https://twitter.com/"+data.user.screen_name+"/status/"+data.id_str)
			  })
			}
		  })
		})
    } else {
        console.log(fileerr);
    }
});
