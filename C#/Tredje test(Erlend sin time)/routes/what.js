var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res, next) {
  res.render('what', { title: 'What in the flying fusk' });
});

module.exports = router;