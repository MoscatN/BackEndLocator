const { createProxyMiddleware } = require('http-proxy-middleware');

const context = [
    "/api/locations",
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: 'https://localhost:7227',
        secure: false
    });

    app.use(appProxy);
};
