var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res, next) {
  let number = Math.random()
  res.render('obiwan', { nr: number });
});

module.exports = router;