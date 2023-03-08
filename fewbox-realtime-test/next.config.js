//const generateSitemap = require('./scripts/generate-sitemap');
const path = require('path');

module.exports = {
    reactStrictMode: true,
    compiler: {
        // Enables the styled-components SWC transform
        styledComponents: true
    },
    //experimental: { esmExternals: true },
    compress: true,
    poweredByHeader: false,
    sassOptions: {
        includePaths: [path.join(__dirname, 'style')],
    },
    webpack: (config, { isServer }) => {
        if (isServer) {
            //generateSitemap();
        }
        config.module.rules.push({
            test: /\.svg$/i,
            issuer: /\.tsx?$/,
            use: ['@svgr/webpack']
        });
        /*config.externals = {
            'appsettings': JSON.stringify(require('./appsettings.json'))
        };*/
        return config;
    }
}