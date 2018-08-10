# node base image provides npm for building angular stuff

# stage - build
FROM node:carbon as build

WORKDIR /app

# just like in .net example, we will do package restore first,
# and maximize our ability to cache that step because it's slow.
COPY package.json package-lock.json ./
RUN npm install

# if we haven't modified package.json, subsequent rebuilds will start here.
# a good optimization.
# run build just like on VSTS.
COPY . ./
RUN npm run build

# nginx is a basic web server for hosting our HTML/CSS/JS website.

# stage - deploy
FROM nginx:1.14 as deploy

# remove the default nginx pages
RUN rm -rf /usr/share/nginx/html/*

# copy our HTML/CSS/JS in.
COPY --from=build /app/dist/pokemon-app /usr/share/nginx/html

# config file which supports deep linking. not required
# COPY nginx-custom.conf /etc/nginx/conf.d/default.conf

# nginx base image already provides a CMD that hosts whatever pages we copied in.
