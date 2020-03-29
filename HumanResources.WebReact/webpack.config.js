"use strict";

module.exports = {
    entry: "./scr/index.js",
    output: {
        filename: "bundle.js"
    },
    module: {
        loaders: [
            {
                test: /\.js$/,
                loader: "babel-loader",
                exclude: [/node_modules/, /public/],
                query: {
                    presets: ["es2015", "react"]
                }
            },
            {
                test: /\.css$/,
                exclude: [/node_modules/, /public/],
                loader: "style-loader!css-loader"
            }
        ]
    }
};