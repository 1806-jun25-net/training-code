# stage - build
FROM node:carbon as build

WORKDIR /app
COPY package.json package-lock.json ./
RUN npm install

COPY . ./
RUN npm run build

# stage - deploy
FROM nginx:1.14 as deploy

RUN rm -rf /usr/share/nginx/html/*

COPY --from=build /app/dist/pokemon-app /usr/share/nginx/html
# COPY nginx-custom.conf /etc/nginx/conf.d/default.conf
