FROM node:carbon as build

WORKDIR /app
COPY package.json package-lock.json ./
RUN npm install

COPY . ./
RUN npm run build

FROM nginx:1.14 as deploy
RUN rm -rf /usr/share/ngix/html/*
COPY --from=build /app/dist/angular-tour-of-heros /usr/share/ngix/html