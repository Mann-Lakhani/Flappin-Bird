# Firebase Hosting Deployment Guide

## Setup Complete!

I've configured your project for Firebase Hosting. Here's what's been set up:

### Configuration Files Created:

1. **firebase.json** - Hosting configuration with:
   - Public directory pointing to "Game Build (Web)"
   - Proper headers for Unity WebGL compressed files (.br)
   - Cache control for optimal performance
   - Single-page app rewrites

2. **.firebaserc** - Project configuration linking to `flappin-bird-f4f03`

3. **.gitignore** - Updated to exclude Firebase cache files

## Deploy Your Game

Since Firebase requires interactive authentication, you need to run these commands in your terminal:

### Step 1: Login to Firebase
```bash
cd "/Users/mannlakhani/Flappy Bird"
firebase login
```

This will open your browser for Google authentication. Sign in with the account that owns the Firebase project.

### Step 2: Deploy
```bash
firebase deploy --only hosting
```

That's it! Your game will be deployed to Firebase Hosting.

## Your Game URL

After deployment, your game will be live at:
- **https://flappin-bird-f4f03.web.app**
- **https://flappin-bird-f4f03.firebaseapp.com**

## Important Notes About Security

### API Keys in Firebase Web Apps

The Firebase configuration you shared contains API keys:
```javascript
apiKey: "AIzaSyBSf1xeC1wpVahHYgCW652zNr5ERawKCy4"
```

**Don't worry - these API keys are safe to expose in web applications!**

Here's why:
- Firebase API keys for web apps are **not secret keys**
- They're meant to be included in your client-side code
- They only identify your Firebase project to Google's servers
- The real security comes from **Firebase Security Rules**, not hidden API keys

### What Actually Protects Your Firebase Project:

1. **Firebase Security Rules** - Configure these in the Firebase Console
2. **Authentication** - Control who can access your data
3. **Authorized domains** - Limit which domains can use your Firebase config

### Best Practices:

✅ **DO:**
- Commit the Firebase config to your repository
- Use Firebase Security Rules to protect your data
- Set up authorized domains in Firebase Console
- Monitor usage in Firebase Console

❌ **DON'T:**
- Don't put Firebase **Admin SDK** credentials in client code
- Don't commit service account JSON files
- Don't share Firebase **private keys** or **secrets**

The config you shared is perfectly safe for a web application!

## Future Updates

To update your game after making changes:

1. Build your Unity project again to "Game Build (Web)"
2. Run: `firebase deploy --only hosting`

## Useful Commands

```bash
# View your deployed site
firebase open hosting:site

# Check deployment status
firebase deploy --only hosting --debug

# Preview before deploying
firebase hosting:channel:deploy preview

# View project info
firebase projects:list
```

## Troubleshooting

If deployment fails:
- Make sure you're logged in: `firebase login --reauth`
- Check you selected the right project: `firebase use flappin-bird-f4f03`
- Verify build files exist: `ls "Game Build (Web)"`

---

Happy deploying! 🚀
