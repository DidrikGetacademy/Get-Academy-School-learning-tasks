console.log("hello all");
const express = require("express");
const axios = require("axios");
const app = express();
app.set("view engine", "ejs");
app.get("/", (req, res) => {
  res.send({ message: "hvasomhelstegt" });
});

app.get("/test/:category", async (req, res) => {
  try {
    const response = await axios.get(
      `https://api.chucknorris.io/jokes/random?category=${req.params.category}`
    );
    res.render("index", {
      joke: response.data.value,
      category: req.params.category,
    });
  } catch (error) {
    res.render("error", { error: error.message });
  }
});
app.listen(3000, () => {
  console.log("server has started and is fucking running");
});
