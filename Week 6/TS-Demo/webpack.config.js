const path = require('path');

module.exports = {
    entry: './out/main.js',
    output: {
        path: path.resolve(__dirname, 'dist'),
        filename: 'bundle.js'
    }
};
